import http from "./base";

export const http404 = async () => {
  const { data: products } = await http.get("/api/buggy/not-found");
  return products;
};

export const http400 = async () => {
  const { data: products } = await http.get("/api/buggy/bad-request");
  return products;
};

export const http401 = async () => {
  const { data: products } = await http.get("/api/buggy/unauthorized");
  return products;
};

export const httpvalidation = async () => {
  const { data: products } = await http.get("/api/buggy/validation-error");
  return products;
};

export const http500 = async () => {
  const { data: products } = await http.get("/api/buggy/server-error");
  return products;
};

export const http403 = async () => {
  const { data: products } = await http.get("/api/buggy/forbidden");
  return products;
};
