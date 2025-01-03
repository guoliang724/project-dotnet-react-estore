import ProductCard from "../productCard";
import { EffectType } from "../../types/product";

import { useAppSelector } from "../../store/slice";

export interface IProps {
  effectType?: EffectType;
}

const ProductList = ({ effectType = EffectType.FLIP }: IProps) => {
  const { unSortedProducts } = useAppSelector((state) => state.products);
  const productList = unSortedProducts
    .slice(0, 8)
    .map((p, i) => (
      <ProductCard key={i} product={p} effectType={effectType} delay={i} />
    ));

  return (
    <div className="w-full">
      <div className="grid grid-cols-4 gap-x-3 gap-y-8">{productList}</div>
    </div>
  );
};

export default ProductList;
