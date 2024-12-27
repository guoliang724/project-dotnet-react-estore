import { keyframes } from "@emotion/react";

/** @type {import('tailwindcss').Config} */
export default {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    extend: {
      fontFamily: {
        Rubik: ["Rubik", "sans-serif"],
        Assitant: ["Assistant", "sans-serif"],
      },
      backgroundSize: {
        auto: "auto",
        cover: "cover",
        contain: "contain",
        "50%": "50%",
        origin: "800px 800px",
      },
      keyframes: {
        cart: {
          "0%": { transform: "scale(1)" },
          "25%": { transform: "scale(0.8)" },
          "50%": { transform: "scale(1.1)" },
          "75%": { transform: "scale(0.9)" },
          "100%": { transform: "scale(1)" },
        },
      },
      animation: {
        cartBounce: "cart 500ms ease-in-out",
      },
      transitionTimingFunction: {
        xRun: "linear",
        yRun: "cubic-bezier(0.5, -0.5, 1, 1)",
      },
    },
  },
  plugins: [require("tailwindcss-content-visibility")],
};
