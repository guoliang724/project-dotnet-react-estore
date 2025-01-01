import {
  http400,
  http401,
  http403,
  http404,
  http500,
  httpvalidation,
} from "../../api/error";
import React, { useState } from "react";
import { Button, Card } from "antd";

function Contact() {
  const [localErrors, setErrors] = useState([]);

  const handle404 = async () => {
    await http404();
  };

  const handle401 = async () => {
    await http401();
  };

  const handle400 = async () => {
    await http400();
  };

  const handle403 = async () => {
    await http403();
  };

  const handle500 = async () => {
    await http500();
  };

  const handlevalidation = async () => {
    await httpvalidation().catch((error) => {
      setErrors(error);
    });
  };

  const ErrorTable = localErrors.map((i) => (
    <li className="text-red-600">* {i}</li>
  ));

  return (
    <div className="w-4/5 mx-auto  flex flex-col gap-6">
      <Card title="For error test purpose" bordered>
        <div className="flex justify-between">
          <Button onClick={handle400}>400 badrequest</Button>
          <Button onClick={handle401}>401 unauthorize</Button>
          <Button onClick={handle403}>403 forbidden</Button>
          <Button onClick={handle404}>404 not found</Button>
          <Button onClick={handle500}>500 server errir</Button>
          <Button onClick={handlevalidation}>unvalidate</Button>
        </div>
      </Card>
      <Card title="Server-side errors" bordered>
        <ul className="flex flex-col gap-3">{ErrorTable}</ul>
      </Card>
    </div>
  );
}

export default Contact;
