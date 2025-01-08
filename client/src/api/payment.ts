
import { IBasketAction } from "../types/basket";
import http from "./base";

export const createPaymentIntent = async()=>{
    return http.post<IBasketAction>("/api/payment",{});
}

