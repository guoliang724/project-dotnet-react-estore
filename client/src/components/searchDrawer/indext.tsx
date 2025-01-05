import React from "react";
import { Drawer } from "antd";
import LoginForm from "../loginForm";

import { useAppSelector, useAppDispatch } from "../../store/slice";

import  "./index.module.less";
import { setIsOpenSearchDrawer } from "../../store/slice/uiSlice";

function SearchDrawer() {
  const { isOpenSearchDrawer } = useAppSelector((state) => state.ui);
  const dispatch = useAppDispatch();

  const handleClose = () => {
    dispatch(setIsOpenSearchDrawer(false));
  };

  return (
    <Drawer
      open={isOpenSearchDrawer}
      placement="top"
      keyboard
      closeIcon={false}
      height={150}
 
      children={<LoginForm onClose={handleClose}></LoginForm>}
      onClose={handleClose}
    ></Drawer>
  );
}

export default SearchDrawer;
