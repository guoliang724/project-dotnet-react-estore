import http from "./base";

export const getProducts = async () => {
  const { data: products } = await http.get("/api/products");
  return products;
};
