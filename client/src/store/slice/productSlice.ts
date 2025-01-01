import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";

import { IProduct } from "../../types/product";
import { getProductDetail, getProducts } from "../../api";

export const fetchProductsAsync = createAsyncThunk<IProduct[]>(
  "product/fetchProductsAsync",
  async () => {
    try {
      return await getProducts();
    } catch (error) {
      console.log("error", error);
      return [];
    }
  }
);

export const fetchProductAsync = createAsyncThunk<IProduct, number>(
  "product/fetchProductAsync",
  async (productId) => {
    try {
      return await getProductDetail(productId.toString());
    } catch (error) {
      console.log("error", error);
      return null;
    }
  }
);

interface IProductState {
  status: string;
  productLoaded: boolean;
  products: IProduct[];
}

const initialState: IProductState = {
  status: "idle",
  productLoaded: false,
  products: [],
};

export const productSlice = createSlice({
  name: "product",
  initialState: initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchProductsAsync.pending, (state) => {
        state.status = "pendingFetchProducts";
      })
      .addCase(fetchProductsAsync.fulfilled, (state, action) => {
        state.products = action.payload;
        state.status = "idle";
        state.productLoaded = true;
      })
      .addCase(fetchProductsAsync.rejected, (state) => {
        state.status = "idle";
      });

    builder
      .addCase(fetchProductAsync.pending, (state) => {
        state.status = "pendingFetchProduct";
      })
      .addCase(fetchProductAsync.fulfilled, (state, action) => {
        // productAdaptor.upsertOne(state, action.payload);
        state.status = "idle";
      })
      .addCase(fetchProductAsync.rejected, (state) => {
        state.status = "idle";
      });
  },
});
