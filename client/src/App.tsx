import { createBrowserRouter, RouterProvider } from "react-router-dom";

import Home from "./page/home";
import AppLayout from "./layout/AppLayout";
import Error from "./components/error/Index";
import ProductDetail, {
  loader as prodcutDetailLoader,
} from "./components/productDetail";
import ContactPage from "./page/contact";
import NewsPage from "./page/news";
import NotFound from "./components/notFound";
import ProductPage from "./page/product";
import BasketPage from "./components/basketPage";
import CheckoutPage from "./components/checkout";

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
          element: <ProductPage />,
        },
        {
          path: "/product/:id",
          loader: prodcutDetailLoader,
          errorElement: <Error />,
          element: <ProductDetail />,
        },
        {
          path: "/contact",
          element: <ContactPage />,
        },
        {
          path: "/basket",
          element: <BasketPage />,
        },
        {
          path: "/checkout",
          element: <CheckoutPage />,
        },
        {
          path: "/news",
          element: <NewsPage />,
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
