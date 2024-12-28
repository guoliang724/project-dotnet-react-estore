import http from "./base";

interface IBasketItem {
  productId: number;
  name: string;
  price: number;
  pictureUrl: string;
  brand: string;
  type: string;
  quantity: number;
}

interface IBasketAction {
  buyerId: string;
  items: IBasketItem[];
  id: number;
}

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
