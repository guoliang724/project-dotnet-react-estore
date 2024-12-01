import React from "react";
import { useRouteError } from "react-router-dom";

function Error() {
  const error = useRouteError();
  console.log("++++++++error", error);
  return <div className="w-3/5 mx-auto my-16">Error....</div>;
}

export default Error;
