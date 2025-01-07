import React from 'react'
import { Button, Descriptions, Badge,Result } from "antd";
import type { DescriptionsProps } from "antd";
import { useNavigate } from 'react-router-dom';

interface IProps {
    orderNumber:number
  }
  

function DoneForm({orderNumber}:IProps) {
  const navigate = useNavigate();
  const handleDone = ()=>{
    navigate("/products")
  }
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
      children: <Badge status="processing" text="Handling" />,
      span: 3,
    }
  ];


  return (
    <div className="w-full flex flex-col justify-around gap-5 mt-10">
      <Result
    status="success"
    title={ <Descriptions title="Successfully Purchased products on eSayClean!" bordered items={items} column={4} />}
    extra={[
      <Button type="primary" onClick={handleDone}>Done</Button>
    ]}
  />
    </div>
  )
}

export default DoneForm