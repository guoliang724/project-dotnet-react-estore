import { Button, Table, Tag, Space, Descriptions, Badge, Image } from "antd";
import type { TableProps } from "antd";
import type { DescriptionsProps } from "antd";
import { useAppSelector } from "../../../store/slice";

interface IProps {
  onNext: () => void;
  onPrevious: () => void;
  current: number;
}

interface DataType {
  key: string;
  product: string;
  pictureUrl: string;
  quantity: number;
  brand: string;
  total: number;
}

function ReviewForm({ onNext, onPrevious }: IProps) {
  const { basket, status } = useAppSelector((state) => state.basket);

  const columns: TableProps<DataType>["columns"] = [
    {
      title: "Product",
      dataIndex: "product",
      key: "product",
      render: (text) => <a>{text}</a>,
      align: "center",
    },
    {
      title: "Picture",
      dataIndex: "pictureUrl",
      key: "pictureUrl",
      render: (url) => <Image width={100} src={url} />,
      align: "center",
    },
    {
      title: "Quantity",
      dataIndex: "quantity",
      key: "quantity",
      align: "center",
    },
    {
      title: "Brand",
      key: "brand",
      dataIndex: "brand",
      render: (_, { brand }) => (
        <Tag color={brand.length > 5 ? "geekblue" : "green"} key={brand}>
          {brand.toUpperCase()}
        </Tag>
      ),
      align: "center",
    },
    {
      title: "Total",
      key: "total",
      dataIndex: "total",
      align: "center",
    },
  ];

  const basketData: DataType[] = basket!.items.map((basket, index) => {
    return {
      key: `${index}`,
      product: basket.name,
      brand: basket.brand,
      quantity: basket.quantity,
      total: basket.price * basket.quantity,
      pictureUrl: basket.pictureUrl,
    };
  });

  const total = basketData.reduce((ac, cu) => cu.total + ac, 0);

  const deliveryFee = total > 100 ? 5.5 : 0;

  const footerItems: DescriptionsProps["items"] = [
    {
      key: "1",
      label: "Subtotal",
      children: total,
      span: 1,
    },
    {
      key: "2",
      label: "Delivery fee*",
      children: deliveryFee,
      span: 1,
    },
    {
      key: "3",
      label: "Total",
      children: total - deliveryFee,
      span: 1,
    },
  ];

  const FooterComp = () => (
    <div className="flex justify-end items-center">
      <Descriptions bordered items={footerItems} column={3} layout="vertical" />
    </div>
  );

  return (
    <div className="flex flex-col gap-4 mt-8">
      <div className="font-Rubik">Order Summary:</div>
      <Table<DataType>
        columns={columns}
        dataSource={basketData}
        bordered
        footer={() => <FooterComp></FooterComp>}
      />

      <div className="self-end flex flex-row justify-center items-center gap-4 mr-20 mt-4">
        <Button size="large" onClick={onPrevious}>
          Back
        </Button>
        <Button size="large" type="primary" onClick={onNext}>
          Next
        </Button>
      </div>
    </div>
  );
}

export default ReviewForm;
