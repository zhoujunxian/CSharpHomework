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
            //ojb.AddOrder("2017302580175", "足球", "赵刚");
            //ojb.DelectOrderByNum("2017302580097");
            //ojb.DelectOrderByName("篮球");
            //ojb.DelectOrderByBuyer("李四");
            //ojb.SearchOrderByNum("2017302580097");
            //ojb.SearchOrderByName("乒乓球");
            //ojb.SearchOrderByBuyer("张三");
            ojb.SearchOrderNumUpTenthousand();
            //ojb.ChangeOrderByNum("2017302580097","123");
            //ojb.ChangeOrderByName("篮球", "排球");
            //ojb.ChangeOrderByBuyer("李四", "轩轩");
            //foreach (string OrderNum in Order.OrderNum)
            //{
            //    Console.Write(OrderNum + "\t");
            //}
            //Console.WriteLine();
            //foreach (string OrderName in Order.OrderName)
            //{
            //    Console.Write(OrderName + "\t");
            //}
            //Console.WriteLine();
            //foreach (string OrderBuyer in Order.OrderBuyer)
            //{
            //    Console.Write(OrderBuyer + "\t");
            //}
            //Console.WriteLine();
        }
    }
}
