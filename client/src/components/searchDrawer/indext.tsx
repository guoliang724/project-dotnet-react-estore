import React from "react";
import { Drawer } from "antd";

import { useAppSelector, useAppDispatch } from "../../store/slice";
import SearchBar from "./searchBar";
import styles from "./index.module.less";
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
      height={110}
      className={styles.searchDrawer}
      children={<SearchBar onClose={handleClose}></SearchBar>}
      onClose={handleClose}
    ></Drawer>
  );
}

export default SearchDrawer;
