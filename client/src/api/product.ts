import { IProductResponse } from "../types/product";
import http from "./base";

export const getProducts = async (params?: URLSearchParams) => {
  let response: IProductResponse = {
    products: [],
    metaData: { totalCount: 0, pageSize: 0, currentPage: 0, totalPages: 0 },
  };
  try {
    const { data } = await http.get<IProductResponse>("/api/products", {
      params,
    });
    if (data) {
      response = data;
    }
  } catch (e) {
    console.log("server went wrong");
  }

  return response;
};

export const getProductDetail = async (id: string) => {
  const { data: product } = await http.get(`/api/products/${id}`);
  return product;
};

export const getFilters = async () => {
  const { data } = await http.get("/api/products/filters");
  return data;
};
