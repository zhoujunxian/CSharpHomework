using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public class Order
    {
        [Key]
        public string Id { get; set; }
        public string  Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
            
        }

        public Order(string id,string  customer,List<OrderItem> orderItems)
        {
            Id = id;
            Customer = customer;
            OrderItems = orderItems;
        }
    }
}
