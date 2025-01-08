import React from "react";
import { Empty, Typography,Button} from "antd";
import { useNavigate } from "react-router-dom";

function NotFound() {
  const navigate = useNavigate();
  return <div className="w-4/5 mx-auto my-16 flex justify-center items-center">
    <Empty
    image="https://gw.alipayobjects.com/zos/antfincdn/ZHrcdLPrvN/empty.svg"
    description={
      <Typography.Text>
        Not Found
      </Typography.Text>
    }
  >
    <Button type="primary" onClick={()=>{navigate('/')}}>Back</Button>
  </Empty>
  </div>;
}

export default NotFound;
