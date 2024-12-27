import React, { ChangeEvent, useState } from "react";

import { Input, message } from "antd";

import {
  FacebookOutlined,
  LinkedinOutlined,
  YoutubeOutlined,
  InstagramOutlined,
  MailOutlined,
} from "@ant-design/icons";

function validateEmail(email: string) {
  var re = /\S+@\S+\.\S+/;
  return re.test(email);
}

const Subscription = () => {
  const [messageApi, contextHolder] = message.useMessage();
  const [email, SetEmail] = useState("");

  const success = (messag: string) => {
    messageApi.open({
      type: "success",
      content: messag,
    });
  };
  const error = (messag: string) => {
    messageApi.open({
      type: "error",
      content: messag,
    });
  };

  const handleOnChange = (e: ChangeEvent<HTMLInputElement>) => {
    SetEmail(e.target.value);
  };

  const handleSubmit = () => {
    // validate email
    if (validateEmail(email)) {
      success("Thanks for subscribing!");
    } else {
      error("It is an invalid email,please try again");
    }
    SetEmail("");
  };

  return (
    <>
      {contextHolder}
      <div className="border-y divide-slate-300 mt-16  py-8">
        <div className="w-4/5 mx-auto">
          <div className="text-lg text-gray-600 mb-6 tracking-wide font-medium">
            Subscribe to our emails
          </div>
          <div className="flex flex-row justify-between items-center">
            <Input
              className="w-60 hover:border-gray-400 focus-within:border-gray-400 text-sm"
              size="middle"
              type="email"
              suffix={
                <MailOutlined
                  className="cursor-pointer"
                  onClick={handleSubmit}
                />
              }
              value={email}
              onChange={handleOnChange}
              placeholder="Email"
            />
            <div className="flex flex-row justify-evenly gap-6">
              <a href="https://www.jsleon.com/" target="_blank">
                <FacebookOutlined />
              </a>
              <a
                target="_blank"
                href="https://www.linkedin.com/in/leon-zhang-cfp%C2%AE-78914656/"
              >
                <LinkedinOutlined />
              </a>
              <a
                target="_blank"
                href="https://www.linkedin.com/in/leon-zhang-cfp%C2%AE-78914656/"
              >
                <YoutubeOutlined />
              </a>
              <a
                target="_blank"
                href="https://www.linkedin.com/in/leon-zhang-cfp%C2%AE-78914656/"
              >
                <InstagramOutlined />
              </a>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default Subscription;
