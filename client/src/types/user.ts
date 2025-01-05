import { IBasketAction } from "./basket";

export interface User {
    email:string,
    token:string,
    basket?: IBasketAction
}


