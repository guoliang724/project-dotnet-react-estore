import ProductCard from "../productCard";
import { EffectType } from "../../types/product";
import SortedBar from "../sortedBar";
import { useAppSelector } from "../../store/slice";
import ProductCardSkeletonList from "../productList/skeleton";

export interface IProps {
  effectType?: EffectType;
}

const ProductPageList = ({ effectType = EffectType.FLIP }: IProps) => {
  const { products, status } = useAppSelector((state) => state.products);

  const productList = products.map((p, i) => (
    <ProductCard key={i} product={p} effectType={effectType} delay={i} />
  ));

  const RenderComponent = status.includes("pendingFetchProducts") ? (
    <ProductCardSkeletonList />
  ) : (
    <div className="grid grid-cols-4 gap-x-3 gap-y-8">{productList}</div>
  );

  return (
    <div className="w-full">
      <div className="text-xl tracking-wide text-gray-600 mb-6 font-medium">
        Featured Products
      </div>
      <SortedBar />
      {RenderComponent}
    </div>
  );
};

export default ProductPageList;
