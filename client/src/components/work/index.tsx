function WorkSection() {
  return (
    <div className="w-3/5 mx-auto my-16 bg-[#fff4e6]">
      <div className="grid grid-cols-2 gap-x-4">
        <div className="flex justify-end">
          <img
            src="https://blobstorage1114.blob.core.windows.net/images/mop-1122-3.jpg"
            className="h-auto object-cover aspect-square"
            alt="image of a fancy brush"
          ></img>
        </div>
        <div className="flex justify-center items-start flex-col px-5">
          <h2 className="font-bold text-2xl tracking-normal">Comet 2001</h2>
          <div className="mt-6 text-sm tracking-wide">
            Soft-bristled makeup brush for flawless foundation application.Nylon
            hairbrush promotes healthy, shiny hair with static control.
          </div>
          <button
            type="button"
            className="mt-6 text-gray-900  border border-gray-300 focus:border-gray-500 hover:border-gray-500  font-medium rounded-lg text-sm px-5 py-2.5 me-2 mb-2"
          >
            Read More
          </button>
        </div>
        <div className="flex justify-center items-start flex-col px-5">
          <h2 className="font-bold text-2xl tracking-normal">Broom Star</h2>
          <div className="mt-6 tracking-wide text-sm">
            Bristle toothbrush with compact head for thorough cleaning.Stiff
            scrub brush for cleaning dishes and pots effortlessly.
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
            src="https://blobstorage1114.blob.core.windows.net/images/mop-1122-1.jpg"
            className="h-auto object-cover aspect-square"
            alt="image of a fancy brush"
          ></img>
        </div>

        <div className="flex justify-end">
          <img
            src="https://blobstorage1114.blob.core.windows.net/images/mop-1122-2.jpg"
            className="h-auto object-cover aspect-square"
            alt="image of a fancy brush"
          ></img>
        </div>
        <div className="flex justify-center items-start flex-col px-5">
          <h2 className="font-bold text-2xl tracking-normal">Aquarius 2003</h2>
          <div className="mt-6 tracking-wide text-sm">
            Detail paintbrush with fine tip for precise artwork.Long-handled
            back brush for easy reach and exfoliation.
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
