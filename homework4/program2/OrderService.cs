using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class OrderService
    {
        
        public void AddOrder(string OrderNum , string OrderName,string OrderBuyer )
        { 
            Order.OrderNum.Add(OrderNum);
            Order.OrderName.Add(OrderName);
            Order.OrderBuyer.Add(OrderBuyer);
        }
        public void DelectOrderByNum(string OrderNum)
        {
            bool flag= Order.OrderNum.Contains(OrderNum);
            if(flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderNum.IndexOf(OrderNum);
                Order.OrderNum.RemoveAt(n);
                Order.OrderName.RemoveAt(n);
                Order.OrderBuyer.RemoveAt(n);
            }
        }
        public void DelectOrderByName(string OrderName)
        {
            bool flag = Order.OrderName.Contains(OrderName);
            if (flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderName.IndexOf(OrderName);
                Order.OrderNum.RemoveAt(n);
                Order.OrderName.RemoveAt(n);
                Order.OrderBuyer.RemoveAt(n);
            }
        }
        public void DelectOrderByBuyer(string OrderBuyer)
        {
            bool flag = Order.OrderBuyer.Contains(OrderBuyer);
            if (flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderBuyer.IndexOf(OrderBuyer);
                Order.OrderNum.RemoveAt(n);
                Order.OrderName.RemoveAt(n);
                Order.OrderBuyer.RemoveAt(n);
            }
        }

        public void SearchOrderByNum(string OrderNum)
        {
            bool flag = Order.OrderNum.Contains(OrderNum);
            if(flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderNum.IndexOf(OrderNum);
                Console.Write(Order.OrderNum[n]+"\t"+Order.OrderName[n]+"\t"+Order.OrderBuyer[n]);
                Console.WriteLine() ;
            }
        }
        public void SearchOrderByName(string OrderName)
        {
            bool flag = Order.OrderName.Contains(OrderName);
            if (flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderName.IndexOf(OrderName);
                Console.Write(Order.OrderNum[n] + "\t" + Order.OrderName[n] + "\t" + Order.OrderBuyer[n]);
                Console.WriteLine();
            }
        }
        public void SearchOrderByBuyer(string OrderBuyer)
        {
            bool flag = Order.OrderBuyer.Contains(OrderBuyer);
            if (flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderBuyer.IndexOf(OrderBuyer);
                Console.Write(Order.OrderNum[n] + "\t" + Order.OrderName[n] + "\t" + Order.OrderBuyer[n]);
                Console.WriteLine();
            }
        }
        public void ChangeOrderByNum(string OldOrderNum, string NewOrderNum)
        {
            bool flag = Order.OrderNum.Contains(OldOrderNum);
            if (flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderNum.IndexOf(OldOrderNum);
                Order.OrderNum[n] = NewOrderNum;
            }
        }
        public void ChangeOrderByName(string OldOrderName, string NewOrderName)
        {
            bool flag = Order.OrderName.Contains(OldOrderName);
            if (flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderName.IndexOf(OldOrderName);
                Order.OrderName[n] = NewOrderName;
            }
        }
        public void ChangeOrderByBuyer(string OldOrderBuyer, string NewOrderBuyer)
        {
            bool flag = Order.OrderBuyer.Contains(OldOrderBuyer);
            if (flag == false)
            {
                Console.WriteLine("未找到订单");
            }
            else
            {
                int n = Order.OrderBuyer.IndexOf(OldOrderBuyer);
                Order.OrderBuyer[n] = NewOrderBuyer;
            }
        }
    }
}
