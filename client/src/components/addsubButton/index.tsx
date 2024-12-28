import React, { useEffect } from "react";
import { Button } from "antd";

import { addToBasket, getBasket } from "../../api";
import { sleep } from "../../api/base";

interface IProps {
  productId: number;
}

function AddSubButton({ productId }: IProps) {
  const ref = React.useRef<HTMLDivElement>(null);
  const [originX, setOriginX] = React.useState(0);
  const [originY, setOriginY] = React.useState(0);
  const [x, setX] = React.useState(0);
  const [y, setY] = React.useState(0);
  const [start, setStart] = React.useState(false);
  const [isLoading, setIsLoading] = React.useState(false);
  const [quantity, setQuantity] = React.useState(0);

  useEffect(() => {
    if (ref.current) {
      var rect = ref.current.getBoundingClientRect();
      setOriginX(rect.x);
      setOriginY(rect.y);
    }
  }, [ref.current]);

  useEffect(() => {
    const getBaseketNow = async (productId: number) => {
      const { data } = await getBasket();
      const quantity = data.items.find(
        (p) => p.productId === productId
      )?.quantity;
      setQuantity(quantity || 0);
    };
    getBaseketNow(productId);
  }, [productId, start]);

  useEffect(() => {
    if (!start || !originX || !originY) return;
    const x1 = 1260; // need redux to get the value of cart
    const y1 = 95;

    const x = x1 - originX;
    const y = y1 - originY;
    setX(x);
    setY(y);
  }, [start, originX, originY]);

  useEffect(() => {
    if (start) {
      const timer = setTimeout(handleTransitionEnd, 550);

      return () => clearTimeout(timer);
    }
  }, [start]);

  const handleTransitionEnd = () => {
    setStart(false);
    setX(0);
    setY(0);
  };

  const handleAddtoBasket = async () => {
    setIsLoading(true);
    setStart(true);
    await sleep(1000);

    try {
      await addToBasket(productId);
    } catch (error) {
      console.log(error);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="flex flex-row justify-between items-center gap-3">
      <Button className="bg-white" shape="circle">
        -
      </Button>
      <span className="">{quantity}</span>
      <div className="relative">
        <Button
          type="primary"
          shape="circle"
          onClick={handleAddtoBasket}
          loading={isLoading}
        >
          {!isLoading && "+"}
        </Button>

        <div
          className={`absolute -top-2 -right-2 ease-xRun transition-transform duration-500 ${
            !start && "invisible"
          }`}
          style={{
            transform: `translateX(${x}px)`,
          }}
          ref={ref}
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
