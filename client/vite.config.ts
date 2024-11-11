import { defineConfig } from "vite";
import react from "@vitejs/plugin-react-swc";
import path from "path";

// https://vite.dev/config/
export default defineConfig({
  server: {
    port: 3000,
    host: true,
    open: true,
  },

  plugins: [react()],
});
