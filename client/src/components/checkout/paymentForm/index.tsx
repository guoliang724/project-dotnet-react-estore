import React,{useEffect,useState} from "react";
import { Form, Input,Button,Row,Col,theme, Checkbox, message} from "antd";

import type { FormProps } from 'antd';
import { FieldData } from "..";
import { createOrder } from "../../../api/orders";
import { isArray } from "lodash";
import { useAppDispatch } from "../../../store/slice";
import { clearBasket } from "../../../store/slice/basketSlice";

interface IProps {
  onNext: () => void;
  onPrevious: () => void;
  current: number;
  fields: FieldData[];
  isSavedAddress:boolean
  onOrdernumber:(n:number)=>void
}

type FieldType = {
  name?: string;
  cardNumber?: string;
  expireDate?: string;
  CVV?:string;
};

function PaymentForm({onNext,onPrevious,fields,isSavedAddress,onOrdernumber}:IProps) {
  const [clientReady, setClientReady] = useState<boolean>(false);
  const [form] = Form.useForm();
  const [isLoading,setLoading] = useState(false);
  const dispatch = useAppDispatch();

  useEffect(() => {
    setClientReady(true);
  }, []);

  const handleSubmit: FormProps<FieldType>['onFinish'] = async (values)=>{
  

     setLoading(true)
     let shippingAddress:any = {}
     fields.forEach(i=>{
        if(i.name && isArray(i.name) && i.value){
          const name = i.name[0]
          shippingAddress[name]= i.value;
        }
     })

  
     
     const {data:numer} = await createOrder({saveAddress:isSavedAddress,shippingAddress})

     if(numer){
      onOrdernumber(numer);
      dispatch(clearBasket());

 
      setLoading(false);
      onNext();
     }
     else {
      message.info("There is a problem, please try again ")
     }
  }
  const { token } = theme.useToken();

  const formStyle: React.CSSProperties = {
    maxWidth: 'none',
    background: token.colorFillAlter,
    borderRadius: token.borderRadiusLG,
    padding: 24,
  };

  return (
    <div className="mt-8 flex flex-col justify-center items-start gap-6">
      <div className="font-Rubik">Payment Method:</div>
      <Form form={form} layout="inline" onFinish={handleSubmit} className="w-full" style={formStyle}>
      <Row gutter={[24,24]}>
       <Col span={12}>
        <Form.Item
          name="name"
          rules={[{ required: true, message: "Please input your FullName!" }]}
          label="Name on card"
        >
          <Input placeholder="Username" />
        </Form.Item>
        </Col>
        <Col span={12}>
        <Form.Item
          name="cardNumber"
          rules={[{ required: true, message: "Please input your Card Number!" }]}
          label="Card Number"
        >
          <Input type="password" placeholder="Password" />
        </Form.Item>
        </Col>
        <Col span={12}>
        <Form.Item
          name="expireDate"
          rules={[{ required: true, message: "Please input your Expire Date!" }]}
          label="Expire Date"
        >
          <Input type="password" placeholder="Password" />
        </Form.Item>
        </Col>
        <Col span={12}>
        <Form.Item
          name="CVV"
          rules={[{ required: true, message: "Please input your CVV!" }]}
          label="CVV"
        >
          <Input type="password" placeholder="Password" />
        </Form.Item>
        </Col>
        <Col span={12}>
          <Checkbox>Remeber cards for next payment</Checkbox>
        </Col>
        <Col span={3}>
         <Form.Item >
            <Button
              onClick={onPrevious}
            >
              Back
            </Button>
         </Form.Item>
         </Col>
        <Col span={3}>
         <Form.Item shouldUpdate>
          {() => (
            <Button
            loading={isLoading}
              type="primary"
              htmlType="submit"
              disabled={
                !clientReady ||
                !form.isFieldsTouched(true) ||
                !!form.getFieldsError().filter(({ errors }) => errors.length)
                  .length
              }
            >
              Place Order
            </Button>
          )}
         </Form.Item>
         </Col>
        </Row>
      </Form>
    </div>
  );
}

export default PaymentForm;
