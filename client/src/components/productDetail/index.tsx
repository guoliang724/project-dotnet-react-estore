import { getProductDetail } from "../../api/product";
import { LoaderFunctionArgs, useLoaderData } from "react-router-dom";
import { IProduct } from "../productCard";

const ProductDetail = () => {
  const product = useLoaderData() as IProduct;
  const { brand, description, id, price, pictureUrl, quantityInStock, type } =
    product;

  return (
    <div className="w-3/5 mx-auto my-16">
      <div>{brand}</div>
      <div>{description}</div>
      <div>{id}</div>
      <div>{price}</div>
      <div>{quantityInStock}</div>
      <div>{type}</div>
      <img src={pictureUrl}></img>
    </div>
  );
};

export const loader = async (args: LoaderFunctionArgs) => {
  const {
    params: { id },
  } = args;
  if (id) return await getProductDetail(id);
  return null;
};

export default ProductDetail;
