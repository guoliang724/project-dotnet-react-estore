export interface MetaData {
  totalCount: number;
  currentPage: number;
  pageSize: number;
  totalPages: number;
}

export class PagniatedRepsonse<T> {
  products: T;
  metaData: MetaData;

  constructor(products: T, metaData: MetaData) {
    this.products = products;
    this.metaData = metaData;
  }
}
