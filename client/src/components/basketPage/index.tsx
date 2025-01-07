import { useState } from "react";
import { Button, Card, Divider, Empty } from "antd";
import { DeleteOutlined } from "@ant-design/icons";

import { useAppDispatch, useAppSelector } from "../../store/slice";

import {
  addBasketItemAsync,
  removeBasketItemAsync,
} from "../../store/slice/basketSlice";
import { IBasketItem } from "../../types/basket";
import { sleep } from "../../api/base";
import OrderSummary from "../orderSummary";

const { Meta } = Card;

function BasketCard({ item, status }: { item: IBasketItem; status: string }) {
  const [isAnimate, setIsAnimate] = useState(false);
  const dispatch = useAppDispatch();

  const handleRemoveAll = async (productId: number, quantity: number) => {
    setIsAnimate(true);
    await sleep(1000);
    dispatch(removeBasketItemAsync({ productId, quantity }));
  };

  const handleRemoveItem = async (productId: number) => {
    dispatch(removeBasketItemAsync({ productId, quantity: 1 }));
  };

  const handleAddItem = async (productId: number) => {
    await sleep(1000);
    dispatch(addBasketItemAsync({ productId }));
  };

  return (
    <Card
      className={`${isAnimate ? "animate-fadeOut" : ""}`}
      cover={<img src={item.pictureUrl} alt="" />}
    >
      <Meta title={item.name} />
      <div className="mt-4 mb-2 flex flex-col">
        <div className="flex flex-row gap-3 justify-start items-center mb-2">
          <span>Quantity: </span>
          <Button
            size="small"
            onClick={() => handleRemoveItem(item.productId)}
            loading={status === "pendingRemoveItem" + item.productId}
            disabled={item.quantity === 0}
          >
            -
          </Button>
          <span>{item.quantity}</span>
          <Button
            size="small"
            onClick={() => handleAddItem(item.productId)}
            loading={status === "pendingAddItem" + item.productId}
          >
            +
          </Button>
        </div>
        <div>
          Toal Price: &nbsp;$
          <span className="text-sm font-medium">
            {(item.price * item.quantity).toFixed(2)}
          </span>
        </div>
        <div className="self-end">
          <DeleteOutlined
            className="text-red-700 cursor-pointer"
            onClick={() => handleRemoveAll(item.productId, item.quantity)}
          />
        </div>
      </div>
    </Card>
  );
}

function BasketPage() {
  const { basket, status } = useAppSelector((state) => state.basket);

  if (!basket)
    return <div className="w-2/3 h-full mx-auto flex justify-center items-center">
      <Empty ></Empty>
    </div>;

  const BasketItemComp = basket.items.map((item, index) => {
    return <BasketCard key={index} item={item} status={status} />;
  });

  return (
    <div className="w-2/3 my-11 mx-auto flex flex-col justify-center items-start gap-5">
      <div className="text-xl font-Rubik font-bold pb-3">
        Your Order Information:
      </div>

      <div className="grid grid-cols-4 gap-4">{BasketItemComp}</div>
      <Divider />
      <div className="self-end"><OrderSummary/></div>
    </div>
  );
}

export default BasketPage;
