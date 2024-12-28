import { useState, useRef, useEffect } from "react";
import { LoaderFunctionArgs, useLoaderData } from "react-router-dom";
import { Swiper, SwiperSlide } from "swiper/react";
import { LeftOutlined, RightOutlined } from "@ant-design/icons";

import { Navigation } from "swiper/modules";
import "swiper/css";
import "swiper/css/navigation";
import "./index.css";

import { getProductDetail } from "../../api/product";
import { IProduct } from "../productCard";
import { Swiper as SwiperType } from "swiper/types";
import AddSubButton from "../addsubButton";

const ProductDetail = () => {
  const product = useLoaderData() as IProduct;
  const swiperRef = useRef<SwiperType>();
  const moveRef = useRef<HTMLDivElement>(null);
  const [isMouseOver, setIsMouseOver] = useState(false);
  const [percentObj, setPercentObj] = useState({ x: 0, y: 0 });

  const [moveDivX, setMoveDivX] = useState(0);
  const [moveDivY, setMoveDivY] = useState(0);
  const [rectMoveDiv, setRectMoveDiv] = useState<DOMRect | null>(null);

  useEffect(() => {
    if (moveRef.current && isMouseOver) {
      setRectMoveDiv(moveRef.current.getBoundingClientRect());
    }
  }, [moveRef.current, isMouseOver]);

  const {
    brand,
    description,
    name,
    price,
    pictureUrl,
    quantityInStock,
    type,
    id,
    demoImages = [],
  } = product;

  const [numberSwiper, setNumberSwiper] = useState(0);
  const [isEnd, setIsEnd] = useState(false);
  const [isBegin, setIsBegin] = useState(true);

  const cubeImageList = [pictureUrl, ...demoImages];

  const DemoImagesList = cubeImageList.map((url, index) => (
    <SwiperSlide key={index}>
      <img
        src={url}
        className="object-cover cursor-pointer hover:brightness-50 transition-all duration-500"
      />
    </SwiperSlide>
  ));

  const handlePrev = () => {
    swiperRef.current?.slidePrev();
  };

  const handleNext = () => {
    swiperRef.current?.slideNext();
  };

  const handleClickSlide = (swiper: SwiperType) => {
    setNumberSwiper(swiper.clickedIndex);
  };

  const handleSlideChange = (swiper: SwiperType) => {
    swiper.isBeginning ? setIsBegin(true) : setIsBegin(false);
    swiper.isEnd ? setIsEnd(true) : setIsEnd(false);
  };

  const handleSmallImageMouseMove = (e: React.MouseEvent<HTMLImageElement>) => {
    setIsMouseOver(true);
    if (rectMoveDiv === null) return;
    e.stopPropagation();

    const offset = {
      x: e.nativeEvent.offsetX,
      y: e.nativeEvent.offsetY,
    };

    const smallWidth = e.currentTarget.clientWidth;
    const smallHeight = e.currentTarget.clientHeight;

    var left = offset.x - rectMoveDiv.width / 2;
    var top = offset.y - rectMoveDiv.height / 2;

    if (left < 0) left = 0;
    if (top < 0) top = 0;
    if (left > smallWidth - rectMoveDiv.width)
      left = smallWidth - rectMoveDiv.width;
    if (top > smallHeight - rectMoveDiv.height)
      top = smallHeight - rectMoveDiv.height;
    setMoveDivX(Math.floor(left));
    setMoveDivY(Math.floor(top));

    const percentX = left / smallWidth;
    const percentY = top / smallHeight;
    setPercentObj({ x: percentX, y: percentY });
  };

  const handleSmallImageMouseLeave = (
    e: React.MouseEvent<HTMLImageElement>
  ) => {
    e.stopPropagation();

    setIsMouseOver(false);
  };

  return (
    <div className="w-4/5 mx-auto my-10">
      <div className="w-full flex flex-row justify-between relative">
        <div className="w-1/2 px-3">
          <div className="w-full flex flex-col gap-y-10 sticky top-5 z-10">
            <div className="w-full px-4 flex justify-center self-center ">
              <div className="w-2/3 relative">
                <div
                  className={`w-72 h-72 bg-contain bg-no-repeat bg-center`}
                  style={{
                    backgroundImage: `url(${cubeImageList[numberSwiper]})`,
                  }}
                  onMouseMove={handleSmallImageMouseMove}
                  onMouseLeave={handleSmallImageMouseLeave}
                />
                <div
                  ref={moveRef}
                  className={`w-24 h-24 bg-green-300 opacity-30 absolute top-0 left-0 pointer-events-none`}
                  style={{
                    transform: `translate(${moveDivX}px, ${moveDivY}px)`,
                    visibility: isMouseOver ? "visible" : "hidden",
                  }}
                ></div>
              </div>
              <div
                className={`absolute w-72 h-72 object-cover z-10 -right-60 top-0 bg-origin bg-no-repeat ${
                  isMouseOver ? "visible" : "hidden"
                }`}
                style={{
                  backgroundImage: `url(${cubeImageList[numberSwiper]})`,
                  backgroundPositionX: `${-650 * percentObj.x}px`,
                  backgroundPositionY: `${-650 * percentObj.y}px`,
                }}
              />
            </div>
            <div className="w-full relative px-14">
              <Swiper
                slidesPerView={4}
                spaceBetween={12}
                modules={[Navigation]}
                onBeforeInit={(swiper) => {
                  swiperRef.current = swiper;
                }}
                onClick={handleClickSlide}
                onSlideChange={handleSlideChange}
              >
                {DemoImagesList}
              </Swiper>
              {!isBegin && (
                <LeftOutlined
                  className={`absolute left-6 top-8`}
                  onClick={handlePrev}
                >
                  Prev
                </LeftOutlined>
              )}
              {!isEnd && (
                <RightOutlined
                  className={`absolute right-6 top-8`}
                  onClick={handleNext}
                >
                  Next
                </RightOutlined>
              )}
            </div>
          </div>
        </div>
        <div className="w-1/2 flex flex-col gap-3 font-Assitant">
          <div className="text-sm tracking-widest opacity-50">{brand}</div>
          <div className="text-4xl tracking-wide">{name}</div>
          <div className="h-12 text-sm flex flex-row justify-start gap-3 align-text-bottom">
            <span className="flex justify-center self-center">&#x24;</span>
            <span className="text-orange-500 text-3xl italic justify-center align-top">
              {price.toFixed(2)}
            </span>
            <span className="text-sm justify-center self-center">USD</span>
            <AddSubButton productId={id} />
          </div>

          <div className="text-green-800 font-medium">
            In Stock: {quantityInStock}
          </div>

          <div className="flex flex-col gap-3">
            <span className="text-lg font-bold">About this item</span>
            <div
              className="flex flex-col gap-3"
              dangerouslySetInnerHTML={{ __html: description }}
            />
            About this item Elevate your bathroom or spa experience with our
            luxuriously soft white rolled towels. Made from premium-quality
            cotton, these towels are ultra-absorbent, durable, and gentle on the
            skin, making them perfect for everyday use or special occasions.
            Each towel is elegantly rolled and displayed on a stylish macrame
            swing, showcasing a clean, minimalist aesthetic that blends
            effortlessly into any décor. Whether you're upgrading your bathroom
            essentials or looking for a thoughtful gift, these towels combine
            practicality with timeless sophistication. Material: 100% Premium
            Cotton Features: Highly absorbent, quick-drying, and soft to the
            touch Ideal For: Bathrooms, spas, or as decorative accents Care
            Instructions: Machine washable, tumble dry on low Bring a touch of
            elegance and comfort to your home with these versatile and
            beautifully designed towels.
          </div>
        </div>
      </div>
    </div>
  );
};

export const loader = async (args: LoaderFunctionArgs) => {
  const {
    params: { id },
  } = args;
  if (id) return await getProductDetail(id);
  return null;
};

export default ProductDetail;
