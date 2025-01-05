import React, { useEffect, useState } from "react";
import { useAppDispatch, useAppSelector } from "../../store/slice";
import { setIsOpenSearchDrawer } from "../../store/slice/uiSlice";

function useRequireAuth() {
  const { user } = useAppSelector((state) => state.account);

  const dispatch = useAppDispatch();

  const [isAuth, setIsAuth] = useState(false);

  useEffect(() => {
    if (user?.email) {
      setIsAuth(true);
    } else {
      setIsAuth(false);

      dispatch(setIsOpenSearchDrawer(true));
    }
  }, [user]);

  return { isAuth };
}

export default useRequireAuth;
