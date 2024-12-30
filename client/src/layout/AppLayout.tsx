import { Outlet } from "react-router-dom";
import Cookies from "js-cookie";
import { useEffect } from "react";

import Announcementbar from "./announcementbar";
import Header from "./header";
import Footer from "./footer";
import AutoScrollTop from "./autoScrollTop";

import { useAppDispatch } from "../store/slice";
import { getBasket } from "../api";
import { setBasket } from "../store/slice/basketSlice";

const AppLayout = () => {
  const dispatch = useAppDispatch();
  useEffect(() => {
    const buyerId = Cookies.get("buyerId");
    if (buyerId) {
      getBasket().then((response) => dispatch(setBasket(response.data)));
    }
  }, [dispatch]);

  return (
    <AutoScrollTop>
      <div className="flex flex-col h-screen">
        <Announcementbar />
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
