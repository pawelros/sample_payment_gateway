using System.Collections.Generic;

namespace WebApplication2.Models
{

    public class OrderItem
    {
        public Product Item { get; set; }

        public int Count { get; set; }
    }


    public class OrderList
    {
        public List<OrderItem> Orders { get; set; }
      
    }
}
