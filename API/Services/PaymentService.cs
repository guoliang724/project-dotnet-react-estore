using API.Entities;
using Stripe;

namespace API.Services
{
    public class PaymentService
    {
        private readonly IConfiguration _config;

        public PaymentService(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<PaymentIntent> CreateOrUpdatePaymentIntent(Basket basket){

            StripeConfiguration.ApiKey = _config["StripeSettings:Secret"];

            var service = new PaymentIntentService();

            var intent = new PaymentIntent();
            var subtotal = basket.Items.Sum(item=>item.Quantity * item.Product.Price)*100;
            var deliveryFee = subtotal > 10000 ? 0: 500;

            if(string.IsNullOrEmpty(basket.PaymentIntentId))
            {
                var options = new PaymentIntentCreateOptions
                {
                    Amount = (long)(subtotal + deliveryFee),
                    Currency = "usd",
                    PaymentMethodTypes = new List<string> { "card" }
                };

                intent = await service.CreateAsync(options);
            }
            else {
                var options = new PaymentIntentUpdateOptions 
                {
                    Amount = (long)(subtotal + deliveryFee)
                };
                await service.UpdateAsync(basket.PaymentIntentId,options);
            }

            return intent;

        }
    }
}