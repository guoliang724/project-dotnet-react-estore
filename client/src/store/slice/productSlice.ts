import { MetaData } from "./../../types/pagination";
import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";

import { IProduct, IProductParams } from "../../types/product";
import { getProducts, getFilters } from "../../api";
import { RootState } from ".";

export const fetchProductsAsync = createAsyncThunk<
  IProduct[],
  void,
  { state: RootState }
>("product/fetchProductsAsync", async (_, thunkAPI) => {
  try {
    const params = getAxiosParams(thunkAPI.getState().products.productParams);
    const response = await getProducts(params);

    thunkAPI.dispatch(setMetaData(response.metaData));

    return response.products;
  } catch (error) {
    console.log("error", error);
    return [];
  }
});

export const fetchUnsortedProductsAsync = createAsyncThunk<
  IProduct[],
  void,
  { state: RootState }
>("product/fetchUnsortedProductsAsync", async (_, thunkAPI) => {
  try {
    const params = getAxiosParams({
      pageNumber: 1,
      pageSize: 100,
      orderBy: "Id",
    });
    const { products } = await getProducts(params);
    return products;
  } catch (error) {
    console.log("error", error);
    return [];
  }
});

// export const fetchProductAsync = createAsyncThunk<IProduct, number>(
//   "product/fetchProductAsync",
//   async (productId) => {
//     try {
//       return await getProductDetail(productId.toString());
//     } catch (error) {
//       console.log("error", error);
//       return null;
//     }
//   }
// );

function getAxiosParams(productParams: IProductParams) {
  const params = new URLSearchParams();
  params.append("pageNumber", productParams.pageNumber.toString());
  params.append("pageSize", productParams.pageSize.toString());
  params.append("orderBy", productParams.orderBy);

  if (productParams.search) {
    params.append("search", productParams.search);
  }
  if (productParams.brands) {
    params.append("brands", productParams.brands.toString());
  }
  if (productParams.types) {
    params.append("types", productParams.types.toString());
  }

  return params;
}

export const fethcFilters = createAsyncThunk(
  "product/fetchFilters",
  async (_, thunkAPI) => {
    try {
      return await getFilters();
    } catch (error) {
      console.log("error", error);
      return [];
    }
  }
);

interface IProductState {
  status: string;
  productLoaded: boolean;
  products: IProduct[];
  filterLoaded: boolean;
  brands: string[];
  types: string[];
  productParams: IProductParams;
  unSortedProducts: IProduct[];
  metaData: MetaData;
}

const initialState: IProductState = {
  status: "idle",
  productLoaded: false,
  products: [],
  filterLoaded: false,
  brands: [],
  types: [],
  productParams: {
    pageNumber: 1,
    pageSize: 8,
    orderBy: "name",
  },
  unSortedProducts: [],
  metaData: {
    totalCount: 0,
    currentPage: 0,
    pageSize: 0,
    totalPages: 0,
  },
};

export const productSlice = createSlice({
  name: "product",
  initialState: initialState,
  reducers: {
    setProductParams: (state, action) => {
      state.productParams = { ...state.productParams, ...action.payload };
    },
    resetProductParams: (state) => {
      state.productParams = initialState.productParams;
    },
    setUnsortedProducts: (state, action) => {
      state.unSortedProducts = action.payload;
    },
    setMetaData: (state, action) => {
      state.metaData = action.payload;
    },
  },
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
      .addCase(fetchUnsortedProductsAsync.pending, (state) => {
        state.status = "fetchUnsortedProductsAsync";
      })
      .addCase(fetchUnsortedProductsAsync.fulfilled, (state, action) => {
        state.status = "idle";
        state.unSortedProducts = action.payload;
      })
      .addCase(fetchUnsortedProductsAsync.rejected, (state) => {
        state.status = "idle";
      });

    builder
      .addCase(fethcFilters.pending, (state) => {
        state.status = "pendingFetchFilters";
      })
      .addCase(fethcFilters.fulfilled, (state, action) => {
        state.brands = action.payload.brands;
        state.types = action.payload.types;
        state.filterLoaded = true;
        state.status = "idle";
      })
      .addCase(fethcFilters.rejected, (state) => {
        state.status = "idle";
      });
  },
});

export const { setProductParams, resetProductParams, setMetaData } =
  productSlice.actions;
