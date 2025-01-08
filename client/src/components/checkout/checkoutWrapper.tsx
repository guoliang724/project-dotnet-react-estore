import { loadStripe } from "@stripe/stripe-js";
import { Elements } from "@stripe/react-stripe-js";
import { Button,Empty,Steps,Typography } from "antd";

import CheckoutPage from ".";
import { useEffect, useState } from "react";
import { useAppDispatch } from "../../store/slice";
import { createPaymentIntent } from "../../api/payment";
import { setBasket } from "../../store/slice/basketSlice";
import useRequireAuth from "../../layout/auth";
import { useNavigate } from "react-router-dom";


const stripePromise = loadStripe(
  "pk_test_51Qel24IuTPWH60wEpBEzSEWnwRMCk1dkyOYaXLBdyu8oUgCdvqxSOxpFvf7JvCIisu5BcWZurJj7k47phgSkjfc3006Osge1fO"
);

function CheckoutWrapper() {
  const dispatch = useAppDispatch();
  const [loading, setLoading] = useState(true);
  const {isAuth}= useRequireAuth();
  const navigate = useNavigate();

  useEffect(() => {
    const createIntent = async () => {
      setLoading(true);
      try {
        const { data: basket } = await createPaymentIntent();
        dispatch(setBasket(basket));
      } catch (err) {
        console.log("createIntent", err);
      } finally {
        setLoading(false);
      }
    };
    if(isAuth) createIntent();
  }, [dispatch,isAuth]);

 

  if(!isAuth) {
    
    return <div className="w-4/5 flex justify-center items-center mx-auto h-full">
      <Empty description={
      <Typography.Text>
        No Authentication
      </Typography.Text>
    }>
      <Button type="primary" onClick={()=>navigate(-1)}>Go back</Button>
      </Empty>
      </div>
 }

  return (
    <Elements stripe={stripePromise}>
      <CheckoutPage></CheckoutPage>
    </Elements>
  );
}

export default CheckoutWrapper;
