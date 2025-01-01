import React from "react";

import { Input } from "antd";
import { CloseSquareOutlined } from "@ant-design/icons";

interface IProps {
  onClose: () => void;
}
function SearchBar({ onClose }: IProps) {
  return (
    <div className="w-full flex justify-center items-center gap-3">
      <Input.Search size="large" className="w-2/3" allowClear />
      <CloseSquareOutlined
        className="text-lg text-gray-400 cursor-pointer"
        onClick={onClose}
      />
    </div>
  );
}

export default SearchBar;
