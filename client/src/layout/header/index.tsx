import React from "react";
import { NavLink } from "react-router-dom";

import logo from "../../../public/logo-2.png";
import search from "../../../public/search.png";
import bag from "../../../public/bag.png";

export default function Header() {
  return (
    <div className="h-20 flex flex-row justify-between mx-40 px-12 py-5 tracking-wider">
      <div className="flex flex-row justify-evenly items-center gap-5">
        <div className="w-30">
          <img src={logo} className="w-full h-8" />
        </div>
        <NavLink to="/" className="hover:underline">
          Home
        </NavLink>
        <NavLink to="/" className="hover:underline">
          Product
        </NavLink>
        <NavLink to="/" className="hover:underline">
          Contact
        </NavLink>
        <NavLink to="/" className="hover:underline">
          News
        </NavLink>
      </div>
      <div className="flex flex-row justify-between items-center gap-10">
        <div>
          <img src={search} className="w-6 h-6"></img>
        </div>
        <div>
          <img src={bag} className="w-5 h-5"></img>
        </div>
      </div>
    </div>
  );
}
