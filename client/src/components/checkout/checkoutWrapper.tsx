import { loadStripe } from "@stripe/stripe-js";
import { Elements } from "@stripe/react-stripe-js";
import { Button,Empty,Typography } from "antd";
import { useEffect } from "react";
import { useNavigate } from "react-router-dom";

import CheckoutPage from ".";

import { useAppDispatch } from "../../store/slice";
import { createPaymentIntent } from "../../api/payment";
import { setBasket } from "../../store/slice/basketSlice";
import useRequireAuth from "../../layout/auth";



const stripePromise = loadStripe(
  "pk_test_51Qel24IuTPWH60wEpBEzSEWnwRMCk1dkyOYaXLBdyu8oUgCdvqxSOxpFvf7JvCIisu5BcWZurJj7k47phgSkjfc3006Osge1fO"
);

function CheckoutWrapper() {
  const dispatch = useAppDispatch();
  const {isAuth}= useRequireAuth();
  const navigate = useNavigate();

  useEffect(() => {
    const createIntent = async () => {

      try {
        const { data: basket } = await createPaymentIntent();
        dispatch(setBasket(basket));
      } catch (err) {
        console.log("createIntent", err);
      } finally {
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
