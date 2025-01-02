import ProductList from "../../components/productList";
import { EffectType } from "../../types/product";

import { useNavigation } from "react-router-dom";

import ProductCardSkeletonList from "../../components/productList/skeleton";
import { useAppSelector } from "../../store/slice";

export interface IProps {
  title: string;
  displayNumber: number;
  effectType: EffectType;
}

const ProductPage = () => {
  const navigation = useNavigation();
  const { products } = useAppSelector((state) => state.products);

  const RenderComponent =
    navigation.state !== "idle" ? (
      <ProductCardSkeletonList />
    ) : (
      <ProductList
        products={products}
        effectType={EffectType.ZOOM}
        isShowSort={true}
      />
    );

  return <div className="w-4/5 mx-auto my-16">{RenderComponent}</div>;
};

export default ProductPage;
