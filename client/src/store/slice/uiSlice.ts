import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";

interface UIProps {
  basketLocation: DOMRect | null;
  isBasketAnimationDone: boolean;
}

const uiInitialState: UIProps = {
  basketLocation: null,
  isBasketAnimationDone: false,
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
  },
});

export const { setBasketLocation, setIsBasketAnimationDone } = uiSlice.actions;
