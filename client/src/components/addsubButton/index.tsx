import React, { useEffect } from "react";
import { Button } from "antd";

import {
  addBasketItemAsync,
  removeBasketItemAsync,
} from "../../store/slice/basketSlice";
import { useAppDispatch, useAppSelector } from "../../store/slice";

interface IProps {
  productId: number;
}

function AddSubButton({ productId }: IProps) {
  const { basket, status } = useAppSelector((state) => state.basket);

  const dispatch = useAppDispatch();
  const quantity = basket?.items.find(
    (i) => i.productId === productId
  )?.quantity;

  const ref = React.useRef<HTMLDivElement>(null);
  const [originX, setOriginX] = React.useState(0);
  const [originY, setOriginY] = React.useState(0);
  const [x, setX] = React.useState(0);
  const [y, setY] = React.useState(0);
  const [start, setStart] = React.useState(false);

  useEffect(() => {
    if (ref.current) {
      var rect = ref.current.getBoundingClientRect();
      setOriginX(rect.x);
      setOriginY(rect.y);
    }
  }, [ref.current]);

  useEffect(() => {
    if (!start || !originX || !originY) return;
    const x1 = 1260; // need redux to get the value of cart
    const y1 = 95;

    const x = x1 - originX;
    const y = y1 - originY;
    setX(x);
    setY(y);
  }, [start, originX, originY]);

  const handleTransitionEnd = () => {
    setStart(false);
    setX(0);
    setY(0);
  };

  const handleAddtoBasket = async () => {
    setStart(true);

    try {
      dispatch(addBasketItemAsync({ productId }));
    } catch (error) {
      console.log(error);
    } finally {
    }
  };

  const handleBaskeSub = async () => {
    try {
      dispatch(removeBasketItemAsync({ productId, quantity: 1 }));
    } catch (error) {
      console.log(error);
    } finally {
    }
  };

  return (
    <div className="flex flex-row justify-between items-center gap-3">
      <Button
        className="bg-white"
        shape="circle"
        disabled={status.includes(`pendingRemoveItem${productId}`) || !quantity}
        onClick={handleBaskeSub}
      >
        -
      </Button>
      <span className="">{quantity ?? 0}</span>
      <div className="relative">
        <Button
          type="primary"
          shape="circle"
          onClick={handleAddtoBasket}
          loading={status.includes(`pendingAddItem${productId}`)}
        >
          {!status.includes(`pendingAddItem${productId}`) && "+"}
        </Button>

        <div
          className={`absolute -top-2 -right-2 ease-xRun transition-transform duration-500 ${
            !start && "invisible"
          }`}
          style={{
            transform: `translateX(${x}px)`,
          }}
          ref={ref}
          onTransitionEnd={handleTransitionEnd}
        >
          <Button
            type="primary"
            shape="circle"
            className="ease-yRun duration-500 transition-transform"
            style={{
              transform: `translateY(${y}px)`,
            }}
          >
            +
          </Button>
        </div>
      </div>
    </div>
  );
}

export default React.memo(AddSubButton);
