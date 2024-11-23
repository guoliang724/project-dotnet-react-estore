import { defineConfig } from "vite";
import react from "@vitejs/plugin-react-swc";
import { resolve } from "path/posix";

// https://vite.dev/config/
export default defineConfig({
  server: {
    port: 3000,
    host: true,
    open: true,
  },
  resolve: {
    alias: [
      { find: "@", replacement: resolve(__dirname, "./src") },
      { find: "imgs", replacement: resolve(__dirname, "src", "imgs") },
    ],
  },
  plugins: [react()],
});
