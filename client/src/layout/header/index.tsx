import React from "react";
import { NavLink } from "react-router-dom";
import {
  LoginOutlined,
  SearchOutlined,
  ShoppingCartOutlined,
} from "@ant-design/icons";

import logo from "../../imgs/logo-page.png";
import logo1 from "../../imgs/logo.svg";

export default function Header() {
  const rightLinks = [
    { path: "/", name: "Home" },
    { path: "products", name: "Product" },
    { path: "/contact", name: "Contact" },
    { path: "/news", name: "News" },
  ];

  const LeftLinkComponent = rightLinks.map((c, i) => (
    <NavLink key={i} to={c.path} className="hover:underline">
      {c.name}
    </NavLink>
  ));

  const RightLinkComponent = (
    <>
      <SearchOutlined className="cursor-pointer" />
      <ShoppingCartOutlined className="cursor-pointer" />
      <LoginOutlined className="cursor-pointer" />
    </>
  );
  return (
    <div className="h-20 flex flex-row justify-between mx-32 py-5 tracking-wider">
      <div className="flex flex-row justify-evenly items-center gap-5">
        <div className="w-30">
          <img src={logo} className="w-full h-8" />
        </div>
        {LeftLinkComponent}
      </div>
      <div className="flex flex-row justify-between items-center gap-10">
        {RightLinkComponent}
      </div>
    </div>
  );
}
