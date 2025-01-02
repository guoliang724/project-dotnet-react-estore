import ProductCard from "../productCard";
import { EffectType, IProduct } from "../../types/product";
import SortedBar from "../sortedBar";

export interface IProps {
  products: IProduct[];
  effectType?: EffectType;
  isShowSort?: boolean;
}

const ProductList = ({
  products,
  effectType = EffectType.FLIP,
  isShowSort,
}: IProps) => {
  const ProductList = [...products].map((p, i) => (
    <ProductCard key={i} product={p} effectType={effectType} delay={i} />
  ));

  return (
    <div className="w-full">
      {isShowSort && (
        <div className="text-xl tracking-wide text-gray-600 mb-6 font-medium">
          Featured Products
        </div>
      )}
      {isShowSort && <SortedBar />}
      <div className="grid grid-cols-4 gap-x-3 gap-y-8">{ProductList}</div>
    </div>
  );
};

export default ProductList;
