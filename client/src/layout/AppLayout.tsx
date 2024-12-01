import { Outlet } from "react-router-dom";
import Announcementbar from "./announcementbar";
import Header from "./header";
import Footer from "./footer";

const AppLayout = () => {
  return (
    <div className="flex-col">
      <Announcementbar />
      <Header></Header>
      <main className="flex-2">
        <Outlet />
      </main>
      <Footer></Footer>
    </div>
  );
};

export default AppLayout;
