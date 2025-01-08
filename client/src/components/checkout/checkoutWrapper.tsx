import { loadStripe } from "@stripe/stripe-js";
import { Elements } from "@stripe/react-stripe-js";

import CheckoutPage from ".";
import { useEffect, useState } from "react";
import { useAppDispatch } from "../../store/slice";
import { createPaymentIntent } from "../../api/payment";
import { setBasket } from "../../store/slice/basketSlice";

const stripePromise = loadStripe(
  "pk_test_51Qel24IuTPWH60wEpBEzSEWnwRMCk1dkyOYaXLBdyu8oUgCdvqxSOxpFvf7JvCIisu5BcWZurJj7k47phgSkjfc3006Osge1fO"
);

function CheckoutWrapper() {
  const dispatch = useAppDispatch();
  const [loading, setLoading] = useState(true);

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
    createIntent();
  }, [dispatch]);

  if(loading) {
    return null;
  }

  return (
    <Elements stripe={stripePromise}>
      <CheckoutPage></CheckoutPage>
    </Elements>
  );
}

export default CheckoutWrapper;
