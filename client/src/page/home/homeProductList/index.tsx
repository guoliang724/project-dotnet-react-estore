import ProductCardSkeletonList from "../../../components/productList/skeleton";
import ProductList from "../../../components/productList";
import { EffectType } from "../../../types/product";

import { useAppSelector } from "../../../store/slice";

function HomeProductList() {
  const { status } = useAppSelector((state) => state.products);

  const RenderComponent = status.includes("pendingFetchProducts") ? (
    <ProductCardSkeletonList />
  ) : (
    <ProductList effectType={EffectType.VIEW} />
  );

  return <div className="w-4/5 mx-auto my-16">{RenderComponent}</div>;
}

export default HomeProductList;
