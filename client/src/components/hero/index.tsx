import React from "react";
import heroImage from "../../../public/images/hero.png";

const Hero: React.FC = () => {
  return (
    <section className="w-full relative">
      <div className="absolute inset-0 z-10 flex flex-col justify-end items-center mb-40">
        <strong className="font-Assitant text-white text-5xl  tracking-wide">
          Spotless homes, happy hearts
        </strong>
        <button
          className="size-5 w-32 h-16 border-[1px] border-white rounded-sm mt-12 
        flex justify-center items-center text-white font-Assitant tracking-wide
        "
        >
          Shop all
        </button>
      </div>
      <div className="items-center relative">
        <img src={heroImage} className="w-full h-2/5 object-fill" />
        <div className="absolute bg-[#0000002a] inset-0"></div>
      </div>
    </section>
  );
};

export default Hero;
