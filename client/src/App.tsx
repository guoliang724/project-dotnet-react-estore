import { useEffect, useState } from "react";

import Header from "./layout/header";
import Content from "./layout/content";
import Hero from "./components/hero";
import Announcementbar from "./layout/announcementbar";

function App() {
  const [data, setData] = useState([]);

  useEffect(() => {
    const getData = async () => {
      const headers = await fetch("http://localhost:5107/api/products");
      const data = await headers.json();
      setData(data);
    };
    getData();
  }, []);
  return (
    <div>
      <Announcementbar />
      <Header />
      <Content>
        <Hero></Hero>
      </Content>
    </div>
  );
}

export default App;
