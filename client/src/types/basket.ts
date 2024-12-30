export interface IBasketItem {
  productId: number;
  name: string;
  price: number;
  pictureUrl: string;
  brand: string;
  type: string;
  quantity: number;
}

export interface IBasketAction {
  buyerId: string;
  items: IBasketItem[];
  id: number;
}
