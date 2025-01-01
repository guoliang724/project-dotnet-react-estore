import ProductCard from "../productCard";
import { EffectType, IProduct } from "../../types/product";

export interface IProps {
  products: IProduct[];
  effectType?: EffectType;
}

const ProductList = ({ products, effectType = EffectType.FLIP }: IProps) => {
  const ProductList = [...products]
    .slice(2, 10)
    .map((p, i) => (
      <ProductCard key={i} product={p} effectType={effectType} delay={i} />
    ));

  return (
    <div className="w-full">
      <div className="text-xl tracking-wide text-gray-600 mb-6 font-medium">
        Featured Products
      </div>
      <div className="grid grid-cols-4 gap-x-3 gap-y-8">{ProductList}</div>
    </div>
  );
};

export default ProductList;
