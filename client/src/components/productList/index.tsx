import ProductCard, { EffectType, IProduct } from "../productCard";
import { getProducts } from "../../api";
import { useLoaderData } from "react-router-dom";

export interface IProps {
  title: string;
  displayNumber: number;
  effectType: EffectType;
}

const ProductList = () => {
  const products = useLoaderData() as IProduct[];

  const ProductList = products
    .splice(0, 8)
    .map((p, i) => (
      <ProductCard key={i} product={p} effectType={EffectType.FLIP} />
    ));

  return (
    <div className="w-3/5 mx-auto my-16">
      <div className="text-xl tracking-wide text-gray-600 mb-6 font-medium">
        Featured Products
      </div>
      <div className="grid grid-cols-4 gap-x-3 gap-y-8">{ProductList}</div>
    </div>
  );
};

export const loader = async () => {
  const products = await getProducts();
  return products;
};

export default ProductList;
