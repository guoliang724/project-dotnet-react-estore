import { Steps } from "antd";
import {
  FormOutlined,
  LoadingOutlined,
  SmileOutlined,
  SolutionOutlined,
  DollarOutlined,
} from "@ant-design/icons";
import { useState } from "react";

import ShippingForm from "./shippingForm";
import ReviewForm from "./reviewForm";
import PaymentForm from "./paymentForm";
import DoneForm from "./doneForm";
import { PaymentResult } from "../../types/payment";

export interface FieldData {
  name: string | number | (string | number)[];
  value?: any;
  touched?: boolean;
  validating?: boolean;
  errors?: string[];
}

function CheckoutPage() {
  const [current, setCurrent] = useState(0);
  const [fields, setFields] = useState<FieldData[]>([]);
  const [isSavedAddress, setIsSaveAddress] = useState(false);
  const [orderNumber, setOrderNumber] = useState(0);
  const [paymentResult, setPaymentResult] = useState<PaymentResult>();

  const next = () => {
    setCurrent(current + 1);
  };

  const prev = () => {
    setCurrent(current - 1);
  };

  const steps = [
    <ShippingForm
      saveAddress={setIsSaveAddress}
      current={current}
      fields={fields}
      onNext={next}
      onChange={setFields}
    ></ShippingForm>,
    <ReviewForm current={current} onNext={next} onPrevious={prev}></ReviewForm>,
    <PaymentForm
      onPayMentSuccess={setPaymentResult}
      current={current}
      onOrdernumber={setOrderNumber}
      onNext={next}
      onPrevious={prev}
      fields={fields}
      isSavedAddress={isSavedAddress}
    ></PaymentForm>,
    <DoneForm
      onPrevious={prev}
      paymentResult={paymentResult}
      orderNumber={orderNumber}
    ></DoneForm>,
  ];

  const items = [
    {
      title: "Shipping address",
      icon: <FormOutlined />,
    },
    {
      title: "Review",
      icon: <SolutionOutlined />,
    },
    {
      title: "Pay",
      icon: current === 2 ? <LoadingOutlined /> : <DollarOutlined />,
    },
    {
      title: "Done",
      icon: <SmileOutlined />,
    },
  ];

  return (
    <div className="w-4/5 mx-auto my-8">
      <Steps current={current} items={items} />
      <div className="w-full">{steps[current]}</div>
    </div>
  );
}

export default CheckoutPage;
