import axios, {
  AxiosError,
  AxiosResponse,
  HttpStatusCode,
} from "axios";
import { message } from "antd";
import { PagniatedRepsonse } from "../types/pagination";
import { store } from "../store/slice";

const http = axios.create({
  baseURL: import.meta.env.VITE_API_URL,
  withCredentials: true,
});

export const sleep = (timer: number) =>
  new Promise((resolve) => setTimeout(resolve, timer));

http.interceptors.request.use((config) => {
  const token = store.getState().account.user?.token;
  if (token) config.headers.Authorization = `Bearer ${token}`;

  return config;
});

http.interceptors.response.use(
  async (response: AxiosResponse) => {
    const pagination = response.headers["pagination"];
    if (pagination) {
      response.data = new PagniatedRepsonse(
        response.data,
        JSON.parse(pagination)
      );
    }

    return response;
  },
  (error: AxiosError) => {
    const { data, status, statusText } = error.response as AxiosResponse;

    switch (status) {
      case HttpStatusCode.BadRequest:
        if (data.errors) {
          const modelStateErrors: string[] = [];
          for (const key in data.errors) {
            if (data.errors[key]) {
              modelStateErrors.push(data.errors[key]);
            }
          }
          message.error(data.title);
          throw modelStateErrors.flat();
        }
        message.error(data.title);
        break;
      case HttpStatusCode.Unauthorized:
        const errorText = data.title
          ? data.title
          : statusText
          ? statusText
          : data;
        message.error(errorText);

        break;
      case HttpStatusCode.NotFound:
        // message.error(data.title);
        break;
      case HttpStatusCode.InternalServerError:
        message.error(data.title);
        break;
      default:
        message.error(data.title);
        break;
    }

    return Promise.reject(error.response);
  }
);

export default http;
