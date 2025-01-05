import { useState } from "react";

import { Form, Input, Button, message } from "antd";

import {
  UserOutlined,
  LockOutlined,
  CloseCircleOutlined,
  MailOutlined,
} from "@ant-design/icons";

import "./index.module.less";

import { useAppDispatch } from "../../store/slice";
import { signIn, signInUser } from "../../store/slice/accountSlice";
import { register } from "../../api/acount";
import { isArray } from "lodash";

interface IProps {
  onClose: () => void;
}

interface Errors {
  [id:string]:""
}

function LoginForm({ onClose }: IProps) {
  const dispatch = useAppDispatch();

  const [form] = Form.useForm();

  const [isLogin, setIsLogin] = useState(true);
  const [isLoading, setLoading] = useState(false);
  const [errors,setErrors] = useState<Errors>({"username":"","email":"","password":""});



  const onFinishLogin = async (values: any) => {
    setLoading(true);
    try {
      dispatch(signInUser(values));
    } catch (err) {
    } finally {
      setLoading(false);
 
      onClose();
      form.setFieldValue("username", "");
      form.setFieldValue("password", "");
    }
  };

  const onFinishRegistor = async (values: any) => {
    setLoading(true);
    try {
      const { data: user } = await register(values);
      if (user) {
        message.success("register success")
        dispatch(signIn(user));
        onClose();
      }
    } catch (err) {
      if(isArray(err)){
           err.map(i=>{
       
              if(i.includes("Username")){
                setErrors((state)=>{
                  return {...state,"username":i};
                })
              } 
              if(i.includes("Email")){
                setErrors((state)=>{
                  return {...state,"email":i};
                })
              } if(i.includes("Password")){
                setErrors((state)=>{
                  return {...state,"password":i};
                })
              } 
           })
      }
     
    } finally {
      setLoading(false);
      // onClose();
      form.setFieldValue("username", "");
      form.setFieldValue("password", "");
      form.setFieldValue("email", "");
    }
  };

  const LoginForm = isLogin ? (
    <Form
      name="login"
      className="flex flex-row gap-4"
      onFinish={onFinishLogin}
      form={form}
    >
      <Form.Item
        name="username"
        rules={[{ required: true, message: "Please input your Username!" }]}
      >
        <Input prefix={<UserOutlined />} placeholder="Username" />
      </Form.Item>
      <Form.Item
        name="password"
        rules={[{ required: true, message: "Please input your Password!" }]}
      >
        <Input
          prefix={<LockOutlined />}
          type="password"
          placeholder="Password"
        />
      </Form.Item>

      <Form.Item>
        <Button block type="primary" htmlType="submit" loading={isLoading}>
          Log in
        </Button>
      </Form.Item>

      <Button color="danger" variant="filled" onClick={() => {
         setIsLogin(false)
         setErrors({"username":"","email":"","password":""}) 
      }}>
        Register
      </Button>
    </Form>
  ) : (
    <div className="relative">
 <Form
      name="register"
      className="flex flex-row gap-4"
      onFinish={onFinishRegistor}
      form={form}
    >
      <Form.Item
        name="username"
        rules={[{ required: true, message: "Please input your Username!" }]}
        help={errors["username"]}
      >
        <Input prefix={<UserOutlined />} placeholder="Username" />
      </Form.Item>
      <Form.Item
        name="email"
        rules={[
          { required: true, message: "Please input your Email!" },
          { type: "email" },
        ]}
        help={errors["email"]}
      >
        <Input prefix={<MailOutlined />} placeholder="Email" />
      </Form.Item>
      <Form.Item
        name="password"
        rules={[{ required: true, message: "Please input your Password!" }]}
        help={errors["password"]}
      >
        <Input
          prefix={<LockOutlined />}
          type="password"
          placeholder="Password"
        />
      </Form.Item>

      <Form.Item>
        <Button block type="primary" htmlType="submit" loading={isLoading}>
          Register
        </Button>
      </Form.Item>

      <Button color="danger" variant="filled" onClick={() => setIsLogin(true)}>
        Login
      </Button>
    </Form>
    {/* <div className="w-[120%] absolute text-red-600">{errors.map((i,index)=><span key={index} className="mr-1">- {i}</span>)}</div> */}
    </div>
   
  );

  return (
    <div className="flex flex-row gap-3 items-center">
      {LoginForm}
      <CloseCircleOutlined onClick={()=>{onClose();setErrors({"username":"","email":"","password":""}) }} className="self-start mt-2" />
    </div>
  );
}

export default LoginForm;
