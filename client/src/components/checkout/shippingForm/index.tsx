import { Form, Input, Checkbox, Button, Row, Col,theme } from "antd";
import type { CheckboxProps } from "antd";

import { FieldData } from "..";

interface CustomizedFormProps {
  onChange: (fields: FieldData[]) => void;
  fields: FieldData[];
  onNext: () => void;
  current: number;
  saveAddress: (b: boolean) => void;
}

export default function ShippingForm({
  onNext,
  onChange,
  fields,
  saveAddress,
}: CustomizedFormProps) {
  const [form] = Form.useForm();
  const isError = !!fields.find((i) => i.errors && i.errors.length > 0);
  const isunFilled =
    fields.length === 0 || !!fields.find((i) => i.value === undefined);

  const isDisable = isError || isunFilled;

  const { token } = theme.useToken();

  const formStyle: React.CSSProperties = {
    maxWidth: 'none',
    background: token.colorFillAlter,
    borderRadius: token.borderRadiusLG,
    padding: 24,
  };

  const handleCheck: CheckboxProps["onChange"] = (e) => {
    saveAddress(e.target.value);
  };
  const handleSubmit = () => {
    onNext();
  };

  return (
    <div className="mt-8 flex flex-col justify-center items-start gap-6">
      <div className="font-Rubik">Shipping Address:</div>
      <Form
        className="w-full"
        size="large"
        fields={fields}
        onFieldsChange={(_, allFields) => {
          onChange(allFields);
        }}
        form={form}
        style={formStyle}
      >
        <Row gutter={16}>
          <Col span={24}>
            <Form.Item
              name="fullname"
              label={<span className="text-sm">Fullname</span>}
              rules={[{ required: true, message: "fullname is required!" }]}
            >
              <Input />
            </Form.Item>
          </Col>
          <Col span={24}>
            <Form.Item
              name="address1"
              label={<span className="text-sm">Address</span>}
              rules={[{ required: true, message: "address is required!" }]}
            >
              <Input />
            </Form.Item>
          </Col>
        </Row>


        <Row gutter={[16, 16]}>
          <Col span={12}>
            <Form.Item
              className="col-span-1"
              name="city"
              label={<span className="text-sm">City</span>}
              rules={[{ required: true, message: "city is required!" }]}
            >
              <Input />
            </Form.Item>
          </Col>
          <Col span={12}>
            <Form.Item
              name="state"
              label={<span className="text-sm">State</span>}
              rules={[{ required: true, message: "state is required!" }]}
            >
              <Input />
            </Form.Item>
          </Col>
        </Row>
        <Row gutter={[16, 16]}>
          <Col span={12}>
            <Form.Item
              name="zipcode"
              label={<span className="text-sm">Zipcode</span>}
              rules={[{ required: true, message: "zipcode is required!" }]}
            >
              <Input />
            </Form.Item>
          </Col>
          <Col span={12}>
            <Form.Item
              name="country"
              label={<span className="text-sm">Country</span>}
              rules={[{ required: true, message: "country is required!" }]}
            >
              <Input />
            </Form.Item>
          </Col>
        </Row>
      </Form>
      <div className="w-full flex flex-col justify-center items-start gap-4 px-2">
        {/* <div className="">
          <Checkbox onChange={handleCheck}>
            Use this address for payment details
          </Checkbox>
        </div> */}
        <div className="self-end">
          <Button type="primary" onClick={handleSubmit} disabled={isDisable}>
            Next
          </Button>
        </div>
      </div>
    </div>
  );
}
