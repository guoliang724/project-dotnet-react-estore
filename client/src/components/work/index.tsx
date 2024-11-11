import React from "react";

import workone from "../../../public/mop-4.jpg";
import worktwo from "../../../public/mop-2.jpg";
import workthree from "../../../public/mop-3.jpg";

function WorkSection() {
  return (
    <div className="w-3/5 mx-auto my-16 bg-[#fff4e6]">
      <div className="grid grid-cols-2 gap-x-4">
        <div className="flex justify-end">
          <img
            src={workone}
            className="h-auto object-cover"
            alt="image of a fancy brush"
          ></img>
        </div>
        <div className="flex justify-center items-start flex-col px-3">
          <h2 className="font-bold text-4xl tracking-normal">Comet 2001</h2>
          <div className="mt-6 tracking-wide">
            Scrub Brush for Cleaning Comfort Grip Shower Scrubber Stiff Bristles
            with Handle Heavy Duty Cleaner Brush for Tub Sink Carpet Floor -
            Pack of 2
          </div>
          <button
            type="button"
            className="mt-6 text-gray-900  border border-gray-300 focus:border-gray-500 hover:border-gray-500  font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2"
          >
            Read More
          </button>
        </div>
        <div className="flex justify-center items-start flex-col px-3">
          <h2 className="font-bold text-4xl tracking-normal">Broom Star</h2>
          <div className="mt-6 tracking-wide">
            Brush Shoe Brush Shoe Cleaning Brush Scrub Brush for
            Stains,Household Cleaning Clothes Shoes Scrubbing,Household Cleaning
            Brushes Bathroom Ergonomics Grip Easy Hold Pack 2
          </div>
          <button
            type="button"
            className="mt-6 text-gray-900  border border-gray-300 focus:border-gray-500 hover:border-gray-500  font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2"
          >
            Read More
          </button>
        </div>
        <div className="flex justify-start">
          <img
            src={worktwo}
            className="h-auto object-cover"
            alt="image of a fancy brush"
          ></img>
        </div>

        <div className="flex justify-end">
          <img
            src={workthree}
            className="h-auto object-cover"
            alt="image of a fancy brush"
          ></img>
        </div>
        <div className="flex justify-center items-start flex-col px-3">
          <h2 className="font-bold text-4xl tracking-normal">Aquarius 2003</h2>
          <div className="mt-6 tracking-wide">
            Scrub Brush, Grout Brush, Pool Brush, Scrub Pads with Scraper Tip
            Scouring Pads, for Pool Walls, Bathroom, Floor, Tub, Shower and
            Kitchen Surface
          </div>
          <button
            type="button"
            className="mt-6 text-gray-900  border border-gray-300 focus:border-gray-500 hover:border-gray-500  font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2"
          >
            Read More
          </button>
        </div>
      </div>
    </div>
  );
}

export default WorkSection;
