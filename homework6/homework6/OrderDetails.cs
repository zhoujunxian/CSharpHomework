using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program2
{
    class OrderDetails
    {
        
        static void Main(string[] args)
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            //ojb.Export();
            //ojb.DelectOrderByNum("2017302580097");
            //ojb.DelectOrderByName("篮球");
            //ojb.DelectOrderByBuyer("李四");
            //ojb.SearchOrderByNum("2017302580097");
            //ojb.SearchOrderByName("乒乓球");
            //ojb.SearchOrderByBuyer("张三");
            //ojb.SearchOrderNumUpTenthousand();
            //ojb.ChangeOrderByNum("2017302580097","123");
            //ojb.ChangeOrderByName("篮球", "排球");
            //ojb.ChangeOrderByBuyer("李四", "轩轩");
            foreach (Order s in Order.orders)
            {
                Console.WriteLine("" + s.number + " " + s.name + " " + s.buyer + " " + s.cost);
                Console.WriteLine();
            }
            //Console.WriteLine();


        }
    }
}
