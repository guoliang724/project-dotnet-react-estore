import axios, { AxiosError, AxiosResponse, HttpStatusCode } from "axios";
import { message } from "antd";

const http = axios.create({
  baseURL: "http://localhost:5107/",
  timeout: 1000,
});

const sleep = (timer: number) =>
  new Promise((resolve) => setTimeout(resolve, timer));

http.interceptors.response.use(
  async (response: AxiosResponse) => {
    // await sleep(1000);

    return response;
  },
  (error: AxiosError) => {
    const { data, status } = error.response as AxiosResponse;

    switch (status) {
      case HttpStatusCode.BadRequest:
        if (data.errors) {
          const modelStateErrors: string[] = [];
          for (const key in data.errors) {
            if (data.errors[key]) {
              modelStateErrors.push(data.errors[key]);
            }
          }
          throw modelStateErrors.flat();
        }
        message.error(data.title);
        break;
      case HttpStatusCode.Unauthorized:
        message.error(data.title);
        break;
      case HttpStatusCode.NotFound:
        message.error(data.title);
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
