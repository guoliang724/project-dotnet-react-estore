import React, { useEffect } from "react";
import { Button } from "antd";

// 1280,95
function AddSubButton() {
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

    setTimeout(() => {
      handleTransitionEnd();
    }, 500);
  }, [start, originX, originY]);

  const handleTransitionEnd = () => {
    setStart(false);
    setX(0);
    setY(0);
  };

  return (
    <div className="flex flex-row justify-between items-center gap-3">
      <Button className="bg-white" shape="circle">
        -
      </Button>
      <span className="">1</span>
      <div className="relative">
        <Button type="primary" shape="circle" onClick={() => setStart(true)}>
          +
        </Button>

        <div
          className={`absolute -top-2 -right-2 ease-xRun duration-500 ${
            !start && "hidden"
          }`}
          style={{
            transform: `translateX(${x}px)`,
          }}
          ref={ref}
        >
          <Button
            type="primary"
            shape="circle"
            className="ease-yRun duration-500"
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
