import { useEffect, useState } from "react";

import Header from "./layout/header";
import Content from "./layout/content";
import Hero from "./components/hero";
import Announcementbar from "./layout/announcementbar";
import WorkSection from "./components/work";
import Testimonial from "./components/testmonial/indext";
import FeaturedIn from "./components/featuredIn";
import ProductList from "./components/productList";
import Subscription from "./components/subscription/indext";
import Footer from "./layout/footer";

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
        <FeaturedIn></FeaturedIn>
        <WorkSection></WorkSection>
        <ProductList></ProductList>
        <Testimonial></Testimonial>
      </Content>
      <Footer></Footer>
    </div>
  );
}

export default App;
