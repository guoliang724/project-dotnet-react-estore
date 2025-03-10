import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";

import { IBasketAction } from "../../types/basket";
import { addToBasket, getBasket, removeFromBasket } from "../../api/basket";

interface BasketState {
  basket: IBasketAction | null;
  status: string;
}

const initialState: BasketState = {
  basket: null,
  status: "idle",
};

export const addBasketItemAsync = createAsyncThunk<
  IBasketAction,
  { productId: number; quantity?: number }
>("basket/addBasketItemAsync", async ({ productId, quantity = 1 }) => {
  const response = await addToBasket(productId, quantity);
  return response.data;
});

export const removeBasketItemAsync = createAsyncThunk<
  void,
  { productId: number; quantity: number }
>("basket/removeBasketItemAsync", async ({ productId, quantity }) => {
  await removeFromBasket(productId, quantity);
});


export const fetchBasketAsync = createAsyncThunk<IBasketAction>(
  "basket/fetchBasket",
  async(_,thunkAPI)=>{
      const {data:baseket} = await getBasket();

      return baseket;
  }
)


export const basketSlice = createSlice({
  name: "basket",
  initialState,
  reducers: {
    setBasket: (state, action) => {
      state.basket = action.payload;
    },
    clearBasket:(state)=>{
      state.basket = null;
    }
  },
  extraReducers: (builder) => {
    builder
      .addCase(addBasketItemAsync.pending, (state, action) => {
        state.status = "pendingAddItem" + action.meta.arg.productId;
      })
      .addCase(addBasketItemAsync.fulfilled, (state, action) => {
        state.status = "idle";
        state.basket = action.payload;
      })
      .addCase(addBasketItemAsync.rejected, (state, action) => {
        state.status = "idle";
      });

    builder
      .addCase(removeBasketItemAsync.pending, (state, action) => {
        state.status = "pendingRemoveItem" + action.meta.arg.productId;
      })
      .addCase(removeBasketItemAsync.fulfilled, (state, action) => {
        const { productId, quantity } = action.meta.arg;
        const itemIndex = state.basket?.items.findIndex(
          (i) => i.productId === productId
        );

        if (itemIndex === -1 || itemIndex === undefined) return;
        state.basket!.items[itemIndex].quantity -= quantity;
        if (state.basket?.items[itemIndex].quantity === 0)
          state.basket.items.splice(itemIndex, 1);

        state.status = "idle";
      })
      .addCase(removeBasketItemAsync.rejected, (state, action) => {
        state.status = "idle";
      });


      builder.addCase(fetchBasketAsync.pending,(state,action)=>{
             state.status = "pendingFetchBasket";
      }).addCase(fetchBasketAsync.fulfilled,(state,action)=>{
             state.basket = action.payload;
             state.status = "idle";
      }).addCase(fetchBasketAsync.rejected,(state,action)=>{
            state.status = "idle";
      })
  },
});

export const { setBasket,clearBasket } = basketSlice.actions;
