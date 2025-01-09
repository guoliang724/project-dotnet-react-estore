import { useRouteError, ErrorResponse } from "react-router-dom";

export enum IErrorMessage {
  NO_SUCH_PRODUCT = "No such product",
}

function Error() {
  const error = useRouteError() as ErrorResponse;

  if (error.data?.title === IErrorMessage.NO_SUCH_PRODUCT) {
    return <div className="w-4/5 mx-auto my-16">{error.data.title}</div>;
  }

  return <div className="w-4/5 mx-auto my-16">This product has not been ready!</div>;
}

export default Error;
