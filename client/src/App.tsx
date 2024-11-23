import { createBrowserRouter, RouterProvider } from "react-router-dom";

import Home from "./page/home";
import AppLayout from "./layout/AppLayout";
import Error from "./components/error/Index";
import ProductList, {
  loader as productListLoader,
} from "./components/productList";
import ProductDetail from "./components/productDetail";
import Contact from "./page/contact";
import News from "./page/news";
import NotFound from "./components/notFound";

function App() {
  const router = createBrowserRouter([
    {
      element: <AppLayout />,
      children: [
        {
          path: "/",
          element: <Home />,
          errorElement: <Error />,
          loader: productListLoader,
        },
        {
          path: "/products",
          loader: productListLoader,
          element: <ProductList />,
        },
        {
          path: "/product/:id",
          element: <ProductDetail />,
        },
        {
          path: "/contact",
          element: <Contact />,
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
