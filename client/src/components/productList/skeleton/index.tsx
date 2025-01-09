

import ProductCardSkeleton from "../../productCard/skeleton";

function ProductCardSkeletonList() {
  const skeletonCardNumber = 8;
  const RenderSkeleton = new Array(skeletonCardNumber)
    .fill(0)
    .map((i, x) => <ProductCardSkeleton key={x} />);

  return (
    <div className="w-full">
      <div className="text-xl tracking-wide text-gray-600 mb-6 font-medium">
        Featured Products
      </div>
      <div className="grid grid-cols-4 gap-x-3 gap-y-8">{RenderSkeleton}</div>
    </div>
  );
}

export default ProductCardSkeletonList;
