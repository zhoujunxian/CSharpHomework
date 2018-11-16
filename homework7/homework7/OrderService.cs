using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace homework7
{
    [Serializable]
    public class OrderService
    {
        public void Export()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = "s.xml";
            XmlSerialize(xmlser, xmlFileName, Order.orders);

            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);
        }
        //反序列化
        public void Import()
        {
            try
            {
                FileStream fs = new FileStream("s.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
                object ojb = new object();
                fs.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void XmlSerialize(XmlSerializer ser, string fileName, object ojb)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, ojb);
            fs.Close();
        }
        //public static object XmlDeserialize(XmlSerializer ser, string FileName)
        //{
        //    FileStream fs = new FileStream("s.xml", FileMode.Open, FileAccess.Read);
        //    XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
        //    object ojb = new object();
        //    fs.Close();
        //    return ojb;
        //}

        public void AddOrder(string OrderNum, string OrderName, string OrderBuyer, double OrderCost)
        {
            Order order = new Order(OrderNum, OrderName, OrderBuyer, OrderCost);
            Order.orders.Add(order);

        }
        public bool DelectOrderByNum(string OrderNum)
        {
            foreach (Order s in Order.orders)
            {
                if (s.Number == OrderNum)
                {
                    Order.orders.Remove(s);
                    return true;
                }
            }
            return false;

        }
        public bool DelectOrderByName(string OrderName)
        {
            foreach (Order s in Order.orders)
            {
                if (s.Name == OrderName)
                {
                    Order.orders.Remove(s);
                    return true;
                }
            }
            return false;
        }
        public bool DelectOrderByBuyer(string OrderBuyer)
        {
            foreach (Order s in Order.orders)
            {
                if (s.Buyer == OrderBuyer)
                {
                    Order.orders.Remove(s);
                    return true;
                }
            }
            return false;
        }

        public void SearchOrderByNum(string OrderNum)
        {
            var order = from s in Order.orders
                        where s.Number.Equals(OrderNum)
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("按订单号搜索出的订单为：" + orders.Number + "，" + orders.Name +
                    "，" + orders.Buyer + "," + orders.Cost);
            }

        }
        public void SearchOrderByName(string OrderName)
        {
            var order = from s in Order.orders
                        where s.Number.Equals(OrderName)
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("按商品名搜索出的订单为：" + orders.Number + "，" + orders.Name +
                    "，" + orders.Buyer + "," + orders.Cost);
            }
        }
        public void SearchOrderByBuyer(string OrderBuyer)
        {
            var order = from s in Order.orders
                        where s.Number.Equals(OrderBuyer)
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("按购买者搜索出的订单为：" + orders.Number + "，" + orders.Name +
                    "，" + orders.Buyer + "," + orders.Cost);
            }
        }
        public void SearchOrderNumUpTenthousand()
        {
            var order = from s in Order.orders
                        where s.Cost > 10000
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("金额超出1万元的订单为：" + orders.Number + "，" + orders.Name +
                    "，" + orders.Buyer + "," + orders.Cost);
            }

        }
        public bool ChangeOrderByNum(string OldOrderNum, string NewOrderNum)
        {
            foreach (Order s in Order.orders)
            {
                if (s.Number == OldOrderNum)
                {
                    s.Number = NewOrderNum;
                    return true;
                }

            }
            return false;
        }
        public bool ChangeOrderByName(string OldOrderName, string NewOrderName)
        {
            foreach (Order s in Order.orders)
            {
                if (s.Name == OldOrderName)
                {
                    s.Name = NewOrderName;
                    return true;
                }

            }
            return false;
        }
        public bool ChangeOrderByBuyer(string OldOrderBuyer, string NewOrderBuyer)
        {
            foreach (Order s in Order.orders)
            {
                if (s.Buyer == OldOrderBuyer)
                {
                    s.Buyer = NewOrderBuyer;
                    return true;
                }

            }
            return false;
        }
    }
}
