import React from "react";
import { Outlet, useNavigation } from "react-router-dom";
import Announcementbar from "./announcementbar";

import Header from "./header";

import Footer from "./footer";
import Loader from "../components/loader";

const AppLayout = () => {
  const navigation = useNavigation();
  console.log("++++++", navigation);
  const isLoading = navigation.state === "loading";

  return (
    <>
      <Announcementbar />
      <Header></Header>
      <main>{isLoading ? <Loader /> : <Outlet />}</main>
      <Footer></Footer>
    </>
  );
};

export default AppLayout;
