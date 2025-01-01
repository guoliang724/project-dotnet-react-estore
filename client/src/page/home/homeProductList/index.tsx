import { useEffect } from "react";
import ProductCardSkeletonList from "../../../components/productList/skeleton";
import ProductList from "../../../components/productList";
import { EffectType } from "../../../types/product";

import { fetchProductsAsync } from "../../../store/slice/productSlice";
import { useAppDispatch, useAppSelector } from "../../../store/slice";

function HomeProductList() {
  const dispatch = useAppDispatch();
  const { productLoaded, products } = useAppSelector((state) => state.products);

  useEffect(() => {
    if (!productLoaded) {
      dispatch(fetchProductsAsync());
    }
  }, [productLoaded, dispatch]);

  const RenderComponent =
    !products || products.length === 0 ? (
      <ProductCardSkeletonList />
    ) : (
      <ProductList products={products} effectType={EffectType.VIEW} />
    );

  return <div className="w-4/5 mx-auto my-16">{RenderComponent}</div>;
}

export default HomeProductList;
