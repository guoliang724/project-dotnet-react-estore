import React from "react";
import { Button, Descriptions, Badge, Result } from "antd";
import type { DescriptionsProps } from "antd";
import { useNavigate } from "react-router-dom";
import { PaymentResult } from "../../../types/payment";

interface IProps {
  orderNumber: number;
  paymentResult: PaymentResult | undefined;
  onPrevious: () => void;
}

function DoneForm({ orderNumber, paymentResult,onPrevious }: IProps) {
  const navigate = useNavigate();
  const handleDone = () => {
    navigate("/products");
  };
  const items: DescriptionsProps["items"] = [
    {
      key: "1",
      label: "Order Number",
      children: orderNumber,
    },
    {
      key: "2",
      label: "Order Time",
      children: "Prepaid",
    },
    {
      key: "3",
      label: "Status",
      children: <Badge status="processing" text="Payment Recieved" />,
      span: 3,
    },
  ];

  const status = paymentResult?.paymentIntent?.status === "succeeded"? "success" : "error";

  const ResultComp =
    status === "success" ? (
      <Result
        status={status}
        title={
          <Descriptions
            title="Successfully Purchased products on eSayClean!"
            bordered
            items={items}
            column={4}
          />
        }
        extra={[
          <Button key="success" type="primary" onClick={handleDone}>
            Done
          </Button>,
        ]}
      />
    ) : (
      <Result
        status={status}
        title="Submission Failed"
        subTitle={paymentResult?.error?.message}
        extra={[<Button key="failed" onClick={onPrevious}>go back and try again</Button>]}
      ></Result>
    );
  return (
    <div className="w-full flex flex-col justify-around gap-5 mt-10">
      {ResultComp}
    </div>
  );
}

export default DoneForm;
