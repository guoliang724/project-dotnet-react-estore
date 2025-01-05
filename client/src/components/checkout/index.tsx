import useRequireAuth from "../../layout/auth";


function CheckoutPage() {
  const {isAuth}= useRequireAuth();


  if(!isAuth) {
     return <div className="w-4/5 mx-auto my-16">Not Authenticated</div>
  }

  return <div className="w-4/5 mx-auto my-16">only for logged in user</div>;
}

export default CheckoutPage;
