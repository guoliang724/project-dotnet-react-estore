import Hero from "../../components/hero";
import WorkSection from "../../components/work";
import Testimonial from "../../components/testmonial/indext";
import FeaturedIn from "../../components/featuredIn";
import ProductList from "../../components/productList";

const Home = () => {
  return (
    <>
      <Hero></Hero>
      <FeaturedIn></FeaturedIn>
      <WorkSection></WorkSection>
      <ProductList></ProductList>
      <Testimonial></Testimonial>
    </>
  );
};

export default Home;
