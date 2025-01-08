import React, { useState } from "react";
import { Form, Input, Button, Row, Col, theme, message } from "antd";

import {
  StripeCardExpiryElementChangeEvent,
  StripeCardNumberElementChangeEvent,
  StripeCardCvcElementChangeEvent,
} from "@stripe/stripe-js";

import {
  useStripe,
  useElements,
  CardNumberElement,
  CardExpiryElement,
  CardCvcElement,
} from "@stripe/react-stripe-js";

import type { FormProps } from "antd";
import { FieldData } from "..";
import { createOrder } from "../../../api/orders";
import { isArray } from "lodash";
import { useAppDispatch, useAppSelector } from "../../../store/slice";
import { clearBasket } from "../../../store/slice/basketSlice";
import { PaymentResult } from "../../../types/payment";

interface IProps {
  onNext: () => void;
  onPrevious: () => void;
  current: number;
  fields: FieldData[];
  isSavedAddress: boolean;
  onOrdernumber: (n: number) => void;
  onPayMentSuccess: (n: PaymentResult) => void;
}

type FieldType = {
  name?: string;
  cardNumber?: string;
  expireDate?: string;
  CVV?: string;
};

interface StripeFormErrorProps {
  [error: string]: string | undefined;
}

function PaymentForm({
  onNext,
  onPrevious,
  fields,
  isSavedAddress,
  onOrdernumber,
  onPayMentSuccess,
}: IProps) {
  const [form] = Form.useForm();
  const [isLoading, setLoading] = useState(false);
  const dispatch = useAppDispatch();

  const stripe = useStripe();
  const elements = useElements();
  const [errorMessage, setErrorMessage] = useState<StripeFormErrorProps>();
  const isError =
    errorMessage &&
    Object.values(errorMessage).filter((i) => i !== undefined).length > 0;
  const [isCardNumberComplete, setCardNumberComplete] = useState(false);
  const [isExpireDateComplete, setCardExpiryComplete] = useState(false);
  const [isCvvComplete, setCardCVVComplete] = useState(false);
  const [nameInputValue, setNameInputValue] = useState("");
  const isEveryInputComplete =
    isCardNumberComplete &&
    isExpireDateComplete &&
    isCvvComplete &&
    nameInputValue;
  const { basket } = useAppSelector((state) => state.basket);

  const { token } = theme.useToken();

  const formStyle: React.CSSProperties = {
    maxWidth: "none",
    background: token.colorFillAlter,
    borderRadius: token.borderRadiusLG,
    padding: 24,
  };

  const handleInputValueChange = (e: any) => {
    setNameInputValue(e.target.value);
  };

  const handleSubmit: FormProps<FieldType>["onFinish"] = async (values) => {
    setLoading(true);

    if (elements == null || stripe == null) {
      return;
    }

    try {
      const cardElemnt = elements.getElement(CardNumberElement);

      const paymentResult = await stripe.confirmCardPayment(
        basket?.clientSecret!,
        {
          payment_method: {
            card: cardElemnt!,
            billing_details: {
              name: values.name,
            },
          },
        }
      );
      onPayMentSuccess(paymentResult);
      if (paymentResult.paymentIntent?.status === "succeeded") {
        await FormSelfLogic();
      }
      
    } catch (error) {
      console.error("paymentresult", error);
    } finally {
      setLoading(false);
      onNext();
    }
  };

  const handleCardNumberChange = (
    event: StripeCardNumberElementChangeEvent
  ) => {
    setCardNumberComplete(event.complete);
    setErrorMessage((err) => {
      err = { ...err, cardNumber: event.error?.message };
      return err;
    });
  };

  const handleCardExpiryChange = (
    event: StripeCardExpiryElementChangeEvent
  ) => {
    setCardExpiryComplete(event.complete);
    setErrorMessage((err) => {
      err = { ...err, cardExpiry: event.error?.message };
      return err;
    });
  };

  const handleCardCVVChange = (event: StripeCardCvcElementChangeEvent) => {
    setCardCVVComplete(event.complete);
    setErrorMessage((err) => {
      err = { ...err, cardCVV: event.error?.message };
      return err;
    });
  };

  const FormSelfLogic = async () => {
    let shippingAddress: any = {};
    fields.forEach((i) => {
      if (i.name && isArray(i.name) && i.value) {
        const name = i.name[0];
        shippingAddress[name] = i.value;
      }
    });

    try {
      const { data: numer } = await createOrder({
        saveAddress: isSavedAddress,
        shippingAddress,
      });

      if (numer) {
        onOrdernumber(numer);
        dispatch(clearBasket());
      } else {
        message.info("There is a problem, please try again ");
      }
    } catch (error: any) {
      console.log("FormSelfLogic", error);
    } finally {
    }
  };

  return (
    <div className="mt-8 flex flex-col justify-center items-start gap-6">
      <div className="font-Rubik">Payment Method:</div>
      <Form
        form={form}
        variant="borderless"
        onFinish={handleSubmit}
        className="w-full"
        style={formStyle}
      >
        <Row gutter={[24, 24]}>
          <Col span={12}>
            <Form.Item
              name="name"
              label="Name on Card"
              rules={[{ required: true, message: "Please input your name" }]}
            >
              <Input
                value={nameInputValue}
                placeholder="Name on Card"
                onChange={handleInputValueChange}
              ></Input>
            </Form.Item>
          </Col>
          <Col span={12}>
            <Form.Item
              name="cardNumber"
              label="Card Number"
              rules={[
                { required: true, message: "Please input your card number" },
              ]}
              help={errorMessage ? errorMessage["cardNumber"] : ""}
            >
              <CardNumberElement
                onChange={handleCardNumberChange}
              ></CardNumberElement>
            </Form.Item>
          </Col>
          <Col span={12}>
            <Form.Item
              name="cardExpiry"
              label="Expire Date"
              rules={[
                { required: true, message: "Please input your card expiry" },
              ]}
              help={errorMessage ? errorMessage["cardExpiry"] : ""}
            >
              <CardExpiryElement
                onChange={handleCardExpiryChange}
              ></CardExpiryElement>
            </Form.Item>
          </Col>
          <Col span={12}>
            <Form.Item
              label="CVV"
              name="cardCVV"
              rules={[
                { required: true, message: "Please input your card CVV" },
              ]}
              help={errorMessage ? errorMessage["cardCVV"] : ""}
            >
              <CardCvcElement onChange={handleCardCVVChange}></CardCvcElement>
            </Form.Item>
          </Col>
          <Col span={16}>
            {/* <Checkbox>Remeber cards for next payment</Checkbox> */}
          </Col>
          <Col span={3}>
            <Button onClick={onPrevious}>Back</Button>
          </Col>
          <Col span={3}>
            <Button
              loading={isLoading}
              type="primary"
              htmlType="submit"
              disabled={
                !stripe || !elements || isError || !isEveryInputComplete
              }
            >
              Place Order
            </Button>
          </Col>
        </Row>
      </Form>
    </div>
  );
}

export default PaymentForm;
