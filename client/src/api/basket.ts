import http from "./base";
import { IBasketAction } from "../types/basket";

export const getBasket = () => {
  return http.get<IBasketAction>("/api/basket");
};

export const addToBasket = (productId: number, quantity = 1) => {
  return http.post<IBasketAction>(
    `/api/basket?productId=${productId}&quantity=${quantity}`,
    {}
  );
};

export const removeFromBasket = (productId: number, quantity = 1) => {
  return http.delete(`/api/basket?productId=${productId}&quantity=${quantity}`);
};
