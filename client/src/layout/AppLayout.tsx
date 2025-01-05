import { Outlet } from "react-router-dom";

import { useEffect } from "react";

import Announcementbar from "./announcementbar";
import Header from "./header";
import Footer from "./footer";
import AutoScrollTop from "./autoScrollTop";

import { useAppDispatch, useAppSelector } from "../store/slice";

import { fetchBasketAsync } from "../store/slice/basketSlice";
import SearchDrawer from "../components/searchDrawer/indext";
import {
  fetchProductsAsync,
  fetchUnsortedProductsAsync,
  fethcFilters,
} from "../store/slice/productSlice";

const AppLayout = () => {
  const dispatch = useAppDispatch();
  const { productLoaded, filterLoaded } = useAppSelector(
    (state) => state.products
  );
  const {user} = useAppSelector(state=>state.account)

  useEffect(() => {
    if(user?.email)
    dispatch(fetchBasketAsync())
  }, [dispatch,user?.email]);

  useEffect(() => {
    if (!productLoaded) {
      dispatch(fetchProductsAsync());
      dispatch(fetchUnsortedProductsAsync());
    }
  }, [productLoaded, dispatch]);

  useEffect(() => {
    if (!filterLoaded) {
      dispatch(fethcFilters());
    }
  }, [filterLoaded, dispatch]);

  return (
    <AutoScrollTop>
      <div className="flex flex-col h-screen">
        <Announcementbar />
        <SearchDrawer />
        <Header></Header>
        <main className="flex-1">
          <Outlet />
        </main>
        <Footer></Footer>
      </div>
    </AutoScrollTop>
  );
};

export default AppLayout;
