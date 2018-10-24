using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program2
{
    
    public class Order
    {
        public string number;
        public string name;
        public string buyer;
        public double cost;
        public string Number { get; set; }
        public string Name { get; set; }
        public string Buyer { get; set; }
        public double Cost { get; set; }

        public static List<Order> orders = new List<Order> { };
        public Order()
        {

        }
        public Order(string Number, string Name, string Buyer, double Cost)
        {
            number = Number;
            name = Name;
            buyer = Buyer;
            cost = Cost;
        }

    }
    
}
