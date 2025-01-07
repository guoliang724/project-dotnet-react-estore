import { Order } from "../types/order";
import http from "./base";

export const getOrders = async()=>{
    return http.get<Order[]>("/api/orders")
}

export const getOrderInfo = async(id:number)=>{
   return http.get(`/api/orders/${id}`)
}

export const createOrder = async(values:any)=>{
    return http.post<number>("/api/orders",values)
}