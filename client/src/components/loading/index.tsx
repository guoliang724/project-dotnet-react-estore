import { Skeleton } from "antd";

function LoadingComponent() {
  return (
    <div className="w-4/5 mx-auto my-16">
      <figure className="flex flex-col">
        <Skeleton.Image className="h-5 w-5" />
        <Skeleton.Node style={{ height: 15 }} />
      </figure>
    </div>
  );
}

export default LoadingComponent;
