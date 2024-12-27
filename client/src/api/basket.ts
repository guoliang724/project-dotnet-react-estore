import http from "./base";

export const getBasket = () => {
  return http.get("basket");
};

export const addToBasket = (productId: number, quantity = 1) => {
  return http.post(`basket?productId=${productId}&quantity=${quantity}`, {});
};

export const removeFromBasket = (productId: number, quantity = 1) => {
  return http.delete(`basket?productId=${productId}&quantity=${quantity}`);
};
