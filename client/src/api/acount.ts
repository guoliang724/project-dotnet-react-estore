import { User } from "../types/user";
import http from "./base";

export const login = (value: any) => {
  return http.post<User>("/api/account/login", value);
};

export const register = (values: any) => {
  return http.post<User>("/api/account/register", values);
};

export const currentUser = () => {
  return http.post<User>("/api/account/currentUser");
};
