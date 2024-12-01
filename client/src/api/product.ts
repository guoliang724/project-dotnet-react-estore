import http from "./base";

export const getProducts = async () => {
  const { data: products } = await http.get("/api/products");
  return products;
};

export const getProductDetail = async (id: string) => {
  const { data: product } = await http.get(`/api/products/${id}`);
  return product;
};
