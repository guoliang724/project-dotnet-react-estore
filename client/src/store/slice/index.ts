import { configureStore } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useDispatch, useSelector } from "react-redux";

import { basketSlice } from "./basketSlice";
import { uiSlice } from "./uiSlice";
import { productSlice } from "./productSlice";

export const store = configureStore({
  reducer: {
    basket: basketSlice.reducer,
    ui: uiSlice.reducer,
    products: productSlice.reducer,
  },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export const useAppDispatch = () => useDispatch<AppDispatch>();
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;

export default store;
