import { keyframes } from "@emotion/react";
import { transform } from "typescript";

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
        fadeOut: {
          "0%": { opacity: 1, transform: "scale(1)" },
          "50%": { opacity: 0.5, transform: "scale(0.9)" },
          "100%": { opacity: 0 },
        },
        fadeIn: {
          "0%": { opacity: 0, transform: "translateY(20px)" },
          "100%": { opacity: 1, transform: "translateY(0)" },
        },
      },
      animation: {
        cartBounce: "cart 800ms ease-in-out",
        fadeOut: "fadeOut 500ms forwards",
        fadeIn: "fadeIn 500ms ease-out forwards",
      },
      transitionTimingFunction: {
        xRun: "linear",
        yRun: "cubic-bezier(0.5, -0.5, 1, 1)",
      },
    },
  },
  plugins: [require("tailwindcss-content-visibility")],
};
