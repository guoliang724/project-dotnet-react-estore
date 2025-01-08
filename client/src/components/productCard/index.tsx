import { Image } from "antd";
import { useNavigate } from "react-router-dom";
import { useState, useRef } from "react";

import { IProductCard, EffectType } from "../../types/product";

export default function ProductCard({
  product: { id, pictureUrl, type, name, description, price },
  effectType,
  delay,
}: IProductCard) {
  const navigate = useNavigate();
  const [url, setUrl] = useState(pictureUrl);
  const ref = useRef<HTMLDivElement>(null);

  const handleMouseOver = () => {
    setUrl(`imgs/products/product-${id}-4.jpg`);
  };

  const handleMouseLeave = () => {
    setUrl(pictureUrl);
  };

  const productDetail = () => {
    navigate(`/product/${id}`, { replace: true });
  };

  const ImageComponent = () => {
    switch (effectType) {
      case EffectType.VIEW:
        return (
          <Image
            className="w-full object-cover"
            src={pictureUrl}
            alt={type}
            preview={{
              getContainer: () => ref.current?.parentNode as HTMLElement,
            }}
          />
        );

      case EffectType.ZOOM:
        return (
          <img
            className="w-full object-cover transition-all hover:scale-110 duration-700"
            src={pictureUrl}
            alt={type}
          />
        );
      default:
        return (
          <img
            className={`w-full  object-cover  transition-all hover:scale-110 duration-700 `}
            alt={type}
            src={url}
            onMouseOver={handleMouseOver}
            onMouseLeave={handleMouseLeave}
          />
        );
    }
  };
  const delySec = effectType === EffectType.ZOOM ? (delay ?? 1) * 250 : 1000;

  return (
    <div
      className={`w-full animate-fadeIn opacity-0`}
      style={{ animationDelay: `${delySec}ms` }}
      ref={ref}
    >
      <figure className={`flex flex-col cursor-pointer`}>
        <div className="overflow-hidden">{ImageComponent()}</div>

        <span
          className="mt-3 mb-2 text-sm line-clamp-2 hover:underline"
          onClick={productDetail}
        >
          {name}
        </span>
        <span>From &#x24; {price.toFixed(2)} USD</span>
      </figure>
    </div>
  );
}
