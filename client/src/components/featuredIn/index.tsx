import React from "react";

import businessInsider from "../../../public/logos/business-insider.png";
import forbes from "../../../public/logos/forbes.png";
import techcrunch from "../../../public/logos/techcrunch.png";
import nyt from "../../../public/logos/the-new-york-times.png";
import usaToday from "../../../public/logos/usa-today.png";

export const FeaturedIn = () => {
  return (
    <div className="w-4/5 mx-auto my-16">
      <div className="uppercase mb-5 text-center text-gray-400 tracking-noraml">
        As Featured In
      </div>
      <div className="flex flex-row justify-around">
        <img
          className="h-8 brightness-0 opacity-40"
          src={businessInsider}
          alt="logo businessInsider"
        />
        <img
          className="h-8 brightness-0 opacity-30"
          src={forbes}
          alt="logo forbes"
        />
        <img
          className="h-8 brightness-0 opacity-30"
          src={techcrunch}
          alt="logo techcrunch"
        />
        <img className="h-8 brightness-0 opacity-30" src={nyt} alt="logo nyt" />
        <img
          className="h-8 brightness-0 opacity-30"
          src={usaToday}
          alt="logo usaToday"
        />
      </div>
    </div>
  );
};

export default FeaturedIn;
