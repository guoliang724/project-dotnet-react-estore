import { IProduct } from "@/components/productCard";
import http from "./base";

export const getProducts = async () => {
  let products: IProduct[] = [];
  try {
    const { data } = await http.get<IProduct[]>("/api/products");
    if (data) {
      products = data;
    }
  } catch (e) {
    console.log("server went wrong");
  }

  return products;
};

export const getProductDetail = async (id: string) => {
  const { data: product } = await http.get(`/api/products/${id}`);
  return product;
};
