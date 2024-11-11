import React from "react";

import ProductCard from "../productCard";

const ProductList = () => {
  return (
    <div className="w-3/5 mx-auto my-16">
      <div className="text-xl tracking-wide text-gray-600 mb-6 font-medium">
        Featured Products
      </div>
      <div className="grid grid-cols-4 gap-x-3 gap-y-8">
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
      </div>
    </div>
  );
};

export default ProductList;
