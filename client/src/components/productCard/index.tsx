import React from "react";
import { Image } from "antd";

import product1 from "../../../public/product/product1.jpg";

export default function ProductCard() {
  return (
    <div className="w-full">
      <figure className="flex flex-col cursor-pointer overflow-hidden">
        <Image
          className="w-full object-cover  overflow-hidden"
          src={product1}
          alt="perfume"
        />
        <span className="mt-3 mb-2 text-sm hover:underline">
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Enim, harum.
        </span>
        <span>&#x24; 9.99 USD</span>
      </figure>
    </div>
  );
}
