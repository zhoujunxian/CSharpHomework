using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace program2
{
    [Serializable]
    public class OrderService
    {
          //XML序列化
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
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void XmlSerialize(XmlSerializer ser,string fileName,object ojb)
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

        public void AddOrder(string OrderNum , string OrderName,string OrderBuyer ,double OrderCost)
        {
            Order order = new Order(OrderNum, OrderName, OrderBuyer, OrderCost);
            Order.orders.Add(order);

        }
        public bool DelectOrderByNum(string OrderNum)
        {
            foreach(Order s in Order.orders)
            {
                if(s.number == OrderNum)
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
                if (s.name == OrderName)
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
                if (s.buyer == OrderBuyer)
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
                        where s.number.Equals(OrderNum)
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("按订单号搜索出的订单为：" + orders.number + "，" + orders.name +
                    "，" + orders.buyer + "," + orders.cost);
            }
 
        }
        public void SearchOrderByName(string OrderName)
        {
            var order = from s in Order.orders
                        where s.number.Equals(OrderName)
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("按商品名搜索出的订单为：" + orders.number + "，" + orders.name +
                    "，" + orders.buyer + "," + orders.cost);
            }
        }
        public void SearchOrderByBuyer(string OrderBuyer)
        {
            var order = from s in Order.orders
                        where s.number.Equals(OrderBuyer)
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("按购买者搜索出的订单为：" + orders.number + "，" + orders.name +
                    "，" + orders.buyer + "," + orders.cost);
            }
        }
        public void SearchOrderNumUpTenthousand()
        {
            var order = from s in Order.orders
                        where s.cost>10000
                        select s;
            foreach (Order orders in order)
            {
                Console.WriteLine("金额超出1万元的订单为：" + orders.number + "，" + orders.name +
                    "，" + orders.buyer + "," + orders.cost);
            }

        }
        public bool ChangeOrderByNum(string OldOrderNum, string NewOrderNum)
        {
            foreach (Order s in Order.orders)
            {
                if (s.number == OldOrderNum)
                {
                    s.number = NewOrderNum;
                    return true;
                }
                
            }
            return false;
        }
        public bool ChangeOrderByName(string OldOrderName, string NewOrderName)
        {
            foreach (Order s in Order.orders)
            {
                if (s.name == OldOrderName)
                {
                    s.name = NewOrderName;
                    return true;
                }

            }
            return false;
        }
        public bool ChangeOrderByBuyer(string OldOrderBuyer, string NewOrderBuyer)
        {
            foreach (Order s in Order.orders)
            {
                if (s.buyer == OldOrderBuyer)
                {
                    s.buyer = NewOrderBuyer;
                    return true;
                }

            }
            return false;
        }
    }
}
