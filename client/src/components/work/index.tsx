import { useAppSelector } from "../../store/slice";
import { useNavigate } from "react-router-dom";



function WorkSection() {
  const { unSortedProducts } = useAppSelector(state=>state.products)
  const navigate = useNavigate();

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
            onClick={() => {
              navigate(`/product/${prodcutone.id}`);
            }
            }
          >
            Read More
          </button>
        </div>
        <div className="flex justify-center items-start flex-col px-5">
          <h2 className="font-bold text-2xl tracking-normal">{prodcuttwo.name}</h2>
          <div className="mt-6 text-sm tracking-wide line-clamp-2">
             {prodcuttwo.literalDescription}
          </div>
          <button
            type="button"
            className="mt-6 text-gray-900  border border-gray-300 focus:border-gray-500 hover:border-gray-500  font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2"
            onClick={() => {
              navigate(`/product/${prodcuttwo.id}`);
            }}
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
          <h2 className="font-bold text-2xl tracking-normal">{productThree.name}3</h2>
          <div className="mt-6 text-sm tracking-wide line-clamp-2">
             {productThree.literalDescription}
          </div>
          <button
            type="button"
            className="mt-6 text-gray-900  border border-gray-300 focus:border-gray-500 hover:border-gray-500  font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2"
            onClick={() => {
              navigate(`/product/${productThree.id}`);
            }}
          >
            Read More
          </button>
        </div>
      </div>
    </div>
  );
}

export default WorkSection;
