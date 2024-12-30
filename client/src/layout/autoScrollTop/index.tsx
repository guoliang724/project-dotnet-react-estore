import React, { useLayoutEffect } from "react";
import { useLocation } from "react-router-dom";

function AutoScrollTop({ children }: { children: React.ReactNode }) {
  const location = useLocation();
  useLayoutEffect(() => {
    document.documentElement.scrollTo(0, 0);
  }, [location.pathname]);

  return children;
}

export default AutoScrollTop;
