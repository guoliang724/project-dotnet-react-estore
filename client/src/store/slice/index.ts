import { combineReducers, configureStore } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useDispatch, useSelector } from "react-redux";
import { persistReducer} from "redux-persist"
import storage from "redux-persist/lib/storage"

import { basketSlice } from "./basketSlice";
import { uiSlice } from "./uiSlice";
import { productSlice } from "./productSlice";
import { accountSlice } from "./accountSlice";
import persistStore from "redux-persist/es/persistStore";


const rootReducer = combineReducers({
  basket: basketSlice.reducer,
  ui: uiSlice.reducer,
  products: productSlice.reducer,
  account:accountSlice.reducer
})

const persistConfig = {
  key:"root",
  storage,
  version:1
  
}

const persistedReducer = persistReducer(persistConfig,rootReducer);


export const store = configureStore({
  reducer: persistedReducer,
  middleware:(getDefaultMiddleware)=>getDefaultMiddleware({serializableCheck:false})
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export const useAppDispatch = () => useDispatch<AppDispatch>();
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;

export const persistor = persistStore(store);
