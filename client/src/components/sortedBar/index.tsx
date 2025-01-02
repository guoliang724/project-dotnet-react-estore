import React from "react";
import { Dropdown } from "antd";
import type { MenuProps } from "antd";
import { DownOutlined } from "@ant-design/icons";

import { useAppDispatch, useAppSelector } from "../../store/slice";

function SortedBar() {
  const { products } = useAppSelector((state) => state.products);
  const length = products.length;

  const items: MenuProps["items"] = [
    {
      key: "1",
      label: <div>1</div>,
    },
    {
      key: "2",
      label: <div>2</div>,
    },
    {
      key: "3",
      label: <div>3</div>,
    },
    {
      key: "4",
      label: <div>5</div>,
    },
  ];

  return (
    <div className="flex flex-row justify-start gap-4 mb-4  font-Assitant">
      <div>Sorted By</div>
      <Dropdown menu={{ items }} trigger={["click"]}>
        <div className="flex flex-row justify-center items-baseline gap-1">
          <span className="cursor-pointer">hover me</span>
          <DownOutlined className="text-[12px] " />
        </div>
      </Dropdown>
      <div className="">{length} products</div>
    </div>
  );
}

export default SortedBar;
