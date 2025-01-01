import React, { useEffect } from "react";
import { NavLink, useNavigate } from "react-router-dom";
import {
  LoginOutlined,
  SearchOutlined,
  ShoppingCartOutlined,
} from "@ant-design/icons";
import { Badge } from "antd";

import logo from "../../imgs/logo-page.png";
import { useAppDispatch, useAppSelector } from "../../store/slice";
import {
  setBasketLocation,
  setIsOpenSearchDrawer,
} from "../../store/slice/uiSlice";

export default function Header() {
  const ref = React.useRef<HTMLDivElement>(null);
  const navigate = useNavigate();
  const { basket } = useAppSelector((state) => state.basket);
  const { isBasketAnimationDone } = useAppSelector((state) => state.ui);
  const dispatch = useAppDispatch();

  const itemNumber = basket?.items.reduce(
    (acc, item) => acc + item.quantity,
    0
  );

  useEffect(() => {
    if (ref.current) {
      const rect = ref.current.getBoundingClientRect();

      dispatch(setBasketLocation(rect.toJSON()));
    }
  }, [ref.current]);

  const handleOnClickBasket = () => {
    navigate("/basket");
  };

  const handleOnOpenSearchDrawer = () => {
    dispatch(setIsOpenSearchDrawer(true));
  };

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
      <SearchOutlined
        className="cursor-pointer"
        onClick={handleOnOpenSearchDrawer}
      />
      <Badge count={itemNumber} size="small" color="geekblue">
        <ShoppingCartOutlined
          className={`cursor-pointer  text-base ${
            isBasketAnimationDone ? "animate-cartBounce" : ""
          }`}
          ref={ref}
          onClick={handleOnClickBasket}
        />
      </Badge>

      <LoginOutlined className="cursor-pointer" />
    </>
  );
  return (
    <div className="min-h-20 flex flex-row justify-between mx-32 py-5 tracking-wider">
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
