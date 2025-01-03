import { Outlet } from "react-router-dom";
import Cookies from "js-cookie";
import { useEffect } from "react";

import Announcementbar from "./announcementbar";
import Header from "./header";
import Footer from "./footer";
import AutoScrollTop from "./autoScrollTop";

import { useAppDispatch, useAppSelector } from "../store/slice";
import { getBasket } from "../api";
import { setBasket } from "../store/slice/basketSlice";
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

  useEffect(() => {
    const buyerId = Cookies.get("buyerId");
    if (buyerId) {
      getBasket().then((response) => dispatch(setBasket(response.data)));
    }
  }, [dispatch]);

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
