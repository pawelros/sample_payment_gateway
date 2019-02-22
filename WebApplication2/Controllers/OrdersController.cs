using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly PaymentGatewayFactory factory;

        public OrdersController(PaymentGatewayFactory factory)
        {
            this.factory = factory;
        }

        // POST api/values
        [HttpPost("/")]
        public IActionResult<PaymentGatewayResponse> Post([FromBody] OrderList orderList)
        {
            int paymentGatewayId = new Random().Next(1, 10);

            if(orderList == null || orderList?.Orders.Any() == false)
            {
                return this.BadRequest();
            }

            decimal total = 0;

            foreach(var order in orderList.Orders)
            {
                total += order.Item.Price * order.Count;
            }

            string currency = "EUR";

            var paymentGateway = this.factory.Get(paymentGatewayId);

            var response = paymentGateway.Book(total, currency);

            return response;
        }
    }
}
