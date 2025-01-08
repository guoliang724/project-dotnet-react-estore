import _workone from "../../imgs/workin/work1.webp";
import _worktwo from "../../imgs/workin/work2.webp";
import _workthree from "../../imgs/workin/work3.webp";
import zipWorkOne from "../../imgs/workin/work1_zon.webp";
import zipWorkTwo from "../../imgs/workin/work2_zon.webp";
import zipWorkThree from "../../imgs/workin/work3_zon.webp";
import { useState } from "react";
import { useAppSelector } from "../../store/slice";



function WorkSection() {
  const { unSortedProducts } = useAppSelector(state=>state.products)

  console.log("+++products",unSortedProducts)
  const prodcutone = unSortedProducts.filter(i=>i.id === 5)[0]
  const prodcuttwo = unSortedProducts.filter(i=>i.id === 6)[0]
  const productThree = unSortedProducts.filter(i=>i.id === 3)[0]



  if(unSortedProducts.length === 0){
    return null
  }


  return (
    <div className="w-4/5 mx-auto my-16 bg-[#fff4e6]">
      <div className="grid grid-cols-2 gap-x-4">
        <div className="flex justify-end">
          <img
            src={prodcutone.pictureUrl}
            className="h-auto object-cover aspect-square "
            alt="image of a fancy brush"
          ></img>
        </div>
        <div className="flex justify-center items-start flex-col px-5">
          <h2 className="font-bold text-2xl tracking-normal">{prodcutone.name}</h2>
          <div className="mt-6 text-sm tracking-wide line-clamp-2">
             {prodcutone.literalDescription}
          </div>
          <button
            type="button"
            className="mt-6 text-gray-900  border border-gray-300 focus:border-gray-500 hover:border-gray-500  font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2"
          >
            Read More
          </button>
        </div>
        <div className="flex justify-center items-start flex-col px-5">
          <h2 className="font-bold text-2xl tracking-normal">{prodcutone.name}</h2>
          <div className="mt-6 text-sm tracking-wide line-clamp-2">
             {prodcutone.literalDescription}
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
            src={prodcuttwo.pictureUrl}
            className="h-auto object-cover aspect-square "
            alt="image of a fancy brush"
          ></img>
        </div>

        <div className="flex justify-end">
          <img
            src={productThree.pictureUrl}
            className="h-auto object-cover aspect-square "
            alt="image of a fancy brush"
          ></img>
        </div>
        <div className="flex justify-center items-start flex-col px-5">
          <h2 className="font-bold text-2xl tracking-normal">{prodcutone.name}3</h2>
          <div className="mt-6 text-sm tracking-wide line-clamp-2">
             {prodcutone.literalDescription}
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
