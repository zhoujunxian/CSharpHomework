using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    public class Order
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Buyer { get; set; }
        public double Cost { get; set; }

        public static List<Order> orders = new List<Order> { };
        public Order()
        {

        }
        public Order(string number, string name, string buyer, double cost)
        {
            Number = number;
            Name = name;
            Buyer = buyer;
            Cost = cost;
        }

    }
}
