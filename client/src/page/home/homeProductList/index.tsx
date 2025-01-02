import ProductCardSkeletonList from "../../../components/productList/skeleton";
import ProductList from "../../../components/productList";
import { EffectType } from "../../../types/product";

import { useAppSelector } from "../../../store/slice";

function HomeProductList() {
  const { products } = useAppSelector((state) => state.products);

  const sliceProducts = [...products].slice(2, 10);

  const RenderComponent =
    !products || products.length === 0 ? (
      <ProductCardSkeletonList />
    ) : (
      <ProductList products={sliceProducts} effectType={EffectType.VIEW} />
    );

  return <div className="w-4/5 mx-auto my-16">{RenderComponent}</div>;
}

export default HomeProductList;
