import image from "../../imgs/testmonial.webp";

const Testimonial = () => {
  return (
    <div className="w-4/5 mx-auto mt-16 bg-gray-100 grid grid-cols-10  shadow-lg rounded-sm">
      <div className="col-span-6 py-1 ps-1">
        <img src={image} className=""></img>
      </div>
      <div className="col-span-4 flex flex-col">
        <div className="h-1/4"></div>
        <div className="h-3/4 flex flex-col  bg-white justify-center items-start p-4">
          <h1 className="text-lg font-bold">
            A Magical Tool Offering A Cleanin House
          </h1>
          <span className="text-sm leading-5 tracking-wide">
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Ipsa,
            expedita provident?
          </span>
        </div>
      </div>
    </div>
  );
};

export default Testimonial;
