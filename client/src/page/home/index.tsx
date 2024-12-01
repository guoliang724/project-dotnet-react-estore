import Hero from "../../components/hero";
import WorkSection from "../../components/work";
import Testimonial from "../../components/testmonial/indext";
import FeaturedIn from "../../components/featuredIn";
import HomeProductList from "./homeProductList";

const Home = () => {
  return (
    <>
      <Hero></Hero>
      <FeaturedIn></FeaturedIn>
      <WorkSection></WorkSection>
      <HomeProductList></HomeProductList>
      <Testimonial></Testimonial>
    </>
  );
};

export default Home;
