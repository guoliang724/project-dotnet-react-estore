import { MetaData } from "./pagination";
export interface IProduct {
  id: number;
  name: string;
  description: "string";
  price: number;
  pictureUrl: string;
  brand: string;
  type: string;
  quantityInStock: number;
  demoImages: string[];
}

export enum EffectType {
  ZOOM = "ZOOM",
  FLIP = "FLIP",
  VIEW = "VIEW",
}

export interface IProductCard {
  product: IProduct;
  effectType?: EffectType;
  delay?: number;
}

export interface IProductParams {
  orderBy: string;
  search?: string;
  brands?: string[];
  types?: string[];
  pageNumber: number;
  pageSize: number;
  count?: number;
}

export interface IProductResponse {
  products: IProduct[];
  metaData: MetaData;
}
