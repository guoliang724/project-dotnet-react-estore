import React, { useState } from "react";
import { useDebounceFn } from "ahooks";
import { Input } from "antd";

import { useAppSelector, useAppDispatch } from "../../../store/slice";
import {
  setProductParams,
  fetchProductsAsync,
} from "../../../store/slice/productSlice";

interface IProps {
  onClose: () => void;
}
function SearchBar({ onClose }: IProps) {
  const { productParams } = useAppSelector((state) => state.products);
  const dispatch = useAppDispatch();

  const [value, setValue] = useState(productParams.search);

  const { run } = useDebounceFn(
    (e: React.ChangeEvent<HTMLInputElement>) => {
      const { value } = e.target;
      dispatch(setProductParams({ ...productParams, search: value }));
      dispatch(fetchProductsAsync());
    },
    {
      wait: 1000,
    }
  );

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { value } = e.target;
    setValue(value);
    run(e);
  };

  return (
    <div className="w-auto flex justify-center items-center">
      <Input.Search
        size="middle"
        className="w-2/3"
        allowClear
        value={value}
        onChange={handleChange}
        variant="filled"
      />
    </div>
  );
}

export default SearchBar;
