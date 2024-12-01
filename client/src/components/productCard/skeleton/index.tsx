import { Skeleton } from "antd";
import React from "react";

function ProductCardSkeleton() {
  return (
    <div className="w-full">
      <figure className="flex flex-col cursor-pointer">
        <Skeleton.Image active style={{ width: "100%" }}></Skeleton.Image>

        <span className="mt-3 mb-2">
          <Skeleton.Input active block></Skeleton.Input>
        </span>
        <span>
          <Skeleton.Input block active></Skeleton.Input>
        </span>
      </figure>
    </div>
  );
}

export default ProductCardSkeleton;
