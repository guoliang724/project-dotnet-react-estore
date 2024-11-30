import React from "react";
import { useParams } from "react-router-dom";

const ProductDetail = () => {
  const { id } = useParams<{ id: string }>();

  return <div className="w-3/5 mx-auto my-16">ProductDetail</div>;
};

export default ProductDetail;
