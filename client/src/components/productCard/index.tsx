import { Image } from "antd";

export interface IProduct {
  productName: string;
  description: "string";
  price: number;
  pictureUrl: string;
  brand: string;
  type: string;
  quantityInStock: number;
}

export default function ProductCard({
  pictureUrl,
  price,
  type,
  description,
}: IProduct) {
  return (
    <div className="w-full">
      <figure className="flex flex-col cursor-pointer overflow-hidden">
        <Image
          className="w-full object-cover overflow-hidden"
          src={pictureUrl}
          alt={type}
        />

        <span className="mt-3 mb-2 text-sm hover:underline">{description}</span>
        <span>From &#x24; {price.toFixed(2)} USD</span>
      </figure>
    </div>
  );
}
