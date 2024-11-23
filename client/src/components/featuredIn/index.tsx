import businessInsider from "../../imgs/brands/business-insider.png";
import forbes from "../../imgs/brands/forbes.png";
import techcrunch from "../../imgs/brands/techcrunch.png";
import nyt from "../../imgs/brands/the-new-york-times.png";
import usaToday from "../../imgs/brands/usa-today.png";

export const FeaturedIn = () => {
  const featuredIn = [
    { src: businessInsider, alt: "logo businessInsider" },
    { src: forbes, alt: "logo forbes" },
    { src: techcrunch, alt: "logo techcrunch" },
    { src: usaToday, alt: "logo usaToday" },
    { src: nyt, alt: "logo nyt" },
  ];

  const FeatureInComponent = featuredIn.map((c, i) => (
    <img
      key={i}
      className="h-6 brightness-0 opacity-40"
      src={c.src}
      alt={c.alt}
    />
  ));
  return (
    <div className="w-4/5 mx-auto my-16">
      <div className="uppercase mb-5 text-center text-gray-400 tracking-noraml">
        As Featured In
      </div>
      <div className="flex flex-row justify-around">{FeatureInComponent}</div>
    </div>
  );
};

export default FeaturedIn;
