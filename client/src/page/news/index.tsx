import { Watermark } from "antd";
import { useAppSelector } from "../../store/slice";

function NewsPage() {
  const {user} = useAppSelector(state=>state.account)
  return <div className="w-4/5 mx-auto my-16">
       <Watermark content={user?.email ?? "eSayClean"}>
    <div style={{ height: 500 }}>
        
    </div> 
    
  </Watermark>
  </div>;
}

export default NewsPage;
