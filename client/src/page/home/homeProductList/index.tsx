import React, { useEffect, useState } from "react";
import ProductCardSkeletonList from "../../../components/productList/skeleton";
import ProductList from "../../../components/productList";
import { EffectType } from "../../../components/productCard";
import { getProducts } from "../../../api";

function HomeProductList() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    getProducts()
      .then((data) => {
        setProducts(data);
      })
      .catch((error) => {
        setProducts([]);
      });
  }, []);

  const RenderComponent =
    products.length === 0 ? (
      <ProductCardSkeletonList />
    ) : (
      <ProductList products={products} effectType={EffectType.VIEW} />
    );

  return <div className="w-4/5 mx-auto my-16">{RenderComponent}</div>;
}

export default HomeProductList;
