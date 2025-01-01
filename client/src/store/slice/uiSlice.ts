import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";

interface UIProps {
  basketLocation: DOMRect | null;
  isBasketAnimationDone: boolean;
  isOpenSearchDrawer: boolean;
}

const uiInitialState: UIProps = {
  basketLocation: null,
  isBasketAnimationDone: false,
  isOpenSearchDrawer: false,
};

export const uiSlice = createSlice({
  name: "ui",
  initialState: uiInitialState,
  reducers: {
    setBasketLocation: (state, action) => {
      state.basketLocation = action.payload;
    },
    setIsBasketAnimationDone: (state, action) => {
      state.isBasketAnimationDone = action.payload;
    },
    setIsOpenSearchDrawer: (state, action) => {
      state.isOpenSearchDrawer = action.payload;
    },
  },
});

export const {
  setBasketLocation,
  setIsBasketAnimationDone,
  setIsOpenSearchDrawer,
} = uiSlice.actions;
