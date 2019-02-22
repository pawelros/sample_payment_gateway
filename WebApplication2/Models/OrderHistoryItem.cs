using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class OrderHistory
    {
        public string paymentId { get; set; }

        public DateTime timestamp { get; set; }

        public List<OrderItem> Orders { get; set; }
    }
}
