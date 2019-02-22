using System;
using System.Linq;

namespace WebApplication2.Models
{
    public class PaymentGatewayFactory
    {
        private readonly IPaymentGateway[] gateways;

        public PaymentGatewayFactory(params IPaymentGateway[] gateways)
        {
            this.gateways = gateways;
        }


        public IPaymentGateway Get(int id)
        {
            var result = this.gateways.FirstOrDefault(p => p.Id == id);

            if (result == null)
            {
                throw new InvalidOperationException($"Payment gateway {id} not found.");
            }

            return result;
        }
    }
}
