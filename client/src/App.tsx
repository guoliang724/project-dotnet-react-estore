import { createBrowserRouter, RouterProvider } from "react-router-dom";

import Home from "./page/home";
import AppLayout from "./layout/AppLayout";
import Error from "./components/error/Index";
import ProductDetail, {
  loader as prodcutDetailLoader,
} from "./components/productDetail";
import Contact from "./page/contact";
import News from "./page/news";
import NotFound from "./components/notFound";
import Product from "./page/product";
import BasketPage from "./components/basketPage";
import Checkout from "./components/checkout";

function App() {
  const router = createBrowserRouter([
    {
      element: <AppLayout />,
      children: [
        {
          path: "/",
          element: <Home />,
          errorElement: <Error />,
        },
        {
          path: "/products",
          element: <Product />,
        },
        {
          path: "/product/:id",
          loader: prodcutDetailLoader,
          errorElement: <Error />,
          element: <ProductDetail />,
        },
        {
          path: "/contact",
          element: <Contact />,
        },
        {
          path: "/basket",
          element: <BasketPage />,
        },
        {
          path: "/checkout",
          element: <Checkout />,
        },
        {
          path: "/news",
          element: <News />,
        },
      ],
    },
    {
      path: "*",
      element: <NotFound />,
    },
  ]);

  return <RouterProvider router={router} />;
}

export default App;
