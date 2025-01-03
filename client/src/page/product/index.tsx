import { EffectType } from "../../types/product";

import ProductPageList from "../../components/productPageList";

export interface IProps {
  title: string;
  displayNumber: number;
  effectType: EffectType;
}

const ProductPage = () => {
  return (
    <div className="w-4/5 mx-auto my-16">
      <ProductPageList effectType={EffectType.ZOOM} />
    </div>
  );
};

export default ProductPage;
