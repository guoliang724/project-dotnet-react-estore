import React, { useEffect, useState } from "react";
import { getOrders } from "../../api/orders";
import { Order } from "../../types/order";
import useRequireAuth from "../../layout/auth";
import { Empty, Typography, Button, Collapse, Tag,Flex, Descriptions, List } from "antd";
import { useNavigate } from "react-router-dom";
import type { CollapseProps } from "antd";
import type { DescriptionsProps } from 'antd';


function OrderPage() {
  const [orders, setOrders] = useState<Order[] | null>(null);
  const [loading, setLoading] = useState(true);
  const navigate = useNavigate();
  const colors = [
    "magenta",
    "red",
    "volcano",
    " orange",
    "gold",
    "lime",
    "green",
    "cyan",
    "blue",
    "geekblue",
    "purple",
  ];

  const { isAuth } = useRequireAuth();

  const onChange = (key: string | string[]) => {
   
  };
 
  useEffect(() => {
    setLoading(true);
    const getOrdersRequest = async () => {
      const { data: order } = await getOrders();
      if (order) {
        setOrders(order);
      }
      setLoading(false);
    };

    getOrdersRequest();
  }, []);

  const isNotAuthCom = !isAuth && (
    <Empty description={<Typography.Text>No Authentication</Typography.Text>}>
      <Button type="primary" onClick={() => navigate(-1)}>
        Go back
      </Button>
    </Empty>
  );

  const LableCom = (order:Order)=> <Flex gap="4px 0" wrap>
    <Tag color="magenta">Order Number: {order.id}</Tag>
    <Tag color="red">Total: {order.total.toFixed(2)}</Tag>
    <Tag color="volcano">Order Date: {order.orderDate.split('T')[0]}</Tag>
    <Tag color="orange">Order Status: {order.orderStatus}</Tag>
    <Tag color="gold">Order's Owner: {order.buyerId}</Tag>
  </Flex>

const ChildDescriptionCom = (order:Order) => {
  const orderInfos = order.orderItems.map(i=><div className="flex flex-row justify-center items-center gap-4">
    <span className="text-blue-800 italic font-bold">Name:</span><span className="truncate">{i.name}</span>
    <span className="text-blue-800 italic font-bold">Quantity:</span>{i.quantity}
    <span className="text-blue-800 italic font-bold">Price:</span> {i.price}
    <span className="text-blue-800 italic font-bold">Total Cost:</span> {i.price * i.quantity}
    <span><img className="w-10 rounded" src={i.pictureUrl}></img></span>
  </div>); 

const ShippingAddressInfo = ()=> <div className="flex flex-row justify-center items-center gap-4">
    <span className="text-blue-800 italic font-bold">Full Name:</span><span className="truncate">{order.shippingAddress.fullName}</span>
    <span className="text-blue-800 italic font-bold">Address:</span><span className="truncate">{order.shippingAddress.address1}</span>
    <span className="text-blue-800 italic font-bold">City:</span>{order.shippingAddress.city}
    <span className="text-blue-800 italic font-bold">State:</span> {order.shippingAddress.state}
    <span className="text-blue-800 italic font-bold">Zip:</span> {order.shippingAddress.zip}

  </div>; 


  const items:DescriptionsProps['items'] = [
    {
        key:"1",
        label:"Order Number",
        children:order.id
    },
    {
        key:"2",
        label:"Order Time",
        children:order.orderDate.split('T')[0]
    },
    {
        key:"3",
        label:"Order Items",
        children:<List grid={{gutter:12}} dataSource={orderInfos}   renderItem={(item) => (
            <List.Item>
              <Typography.Text mark>{item}</Typography.Text> 
            </List.Item>
          )}/>,
          span:24
    },
    {
        key:"4",
        label:"Shipping Address",
        children:<ShippingAddressInfo />,
        span:24,
        
    }
  ]
    
  return <Descriptions bordered column={2} items={items} title={`Order Time:  ${order.orderDate.split('T')[0]}`}></Descriptions>;
}

  const items: CollapseProps["items"] = orders
    ? [...orders].reverse().map((order, index) => {
        return {
          key: index,
          label:LableCom(order),
          children: ChildDescriptionCom(order),
        };
      })
    : [
        {
          key: "1",
          label: <Tag color="magenta">No Order</Tag>,
          children: <p>Your order is empty</p>,
        },
      ];
  const CollapseCom = () => (
    <Collapse
      items={items}
      defaultActiveKey={["0"]}
      onChange={onChange}
    ></Collapse>
  );
 
  const SkeletonCom = () => <div></div>;
  const isLoadingSkeleton = loading ? <CollapseCom /> : <CollapseCom />;
  const isAuthCom = isAuth && isLoadingSkeleton;

  return (
    <div className="w-4/5 mx-auto my-8">
      {isNotAuthCom}
      {isAuthCom}
    </div>
  );
}

export default OrderPage;
