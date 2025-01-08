import React from "react";
import { useNavigate } from "react-router-dom";

const Hero: React.FC = () => {
  const navigate = useNavigate();
  const handleShopAll = () => {
    navigate("/products");
  };
  return (
    <section className="w-full relative flex flex-col">
      <div className="absolute inset-0 z-10 flex flex-col justify-end items-center mb-20">
        <strong className="font-Assitant text-white text-4xl  tracking-wide">
          Spotless homes, happy hearts
        </strong>
        <button
          className="w-32 h-14 border-[1px] border-white rounded-sm mt-12 
        flex justify-center items-center text-white font-Assitant tracking-wide"
          onClick={handleShopAll}
        >
          Shop all
        </button>
      </div>
      <div className="items-center relative">
        <img src="https://blobstorage1114.blob.core.windows.net/images/hero.webp" className="w-full h-[450px] object-fill" />
        <div className="absolute bg-[#0000002a] inset-0"></div>
      </div>
    </section>
  );
};

export default Hero;
