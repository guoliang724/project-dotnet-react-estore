import ProductList from "../../components/productList";
import { EffectType, IProduct } from "../../types/product";

import { getProducts } from "../../api";
import { useLoaderData, useNavigation } from "react-router-dom";

import ProductCardSkeletonList from "../../components/productList/skeleton";

export interface IProps {
  title: string;
  displayNumber: number;
  effectType: EffectType;
}

const Product = () => {
  const products = useLoaderData() as IProduct[];
  const navigation = useNavigation();

  const RenderComponent =
    navigation.state !== "idle" ? (
      <ProductCardSkeletonList />
    ) : (
      <ProductList products={products} effectType={EffectType.ZOOM} />
    );

  return <div className="w-4/5 mx-auto my-16">{RenderComponent}</div>;
};

export const loader = async () => {
  const products = await getProducts();
  return products;
};

export default Product;
