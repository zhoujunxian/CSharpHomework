using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace homework8
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

        public void AddOrder(string OrderNum, string OrderName, string OrderBuyer, double OrderCost,string OrderPhoneNum)
        {
            Order order = new Order(OrderNum, OrderName, OrderBuyer, OrderCost,OrderPhoneNum);
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

        public bool DelectOrderByPhoneNum(string OrderPhoneNum)
        {
            foreach (Order s in Order.orders)
            {
                if (s.PhoneNum == OrderPhoneNum)
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
                    "，" + orders.Buyer + "," + orders.Cost + "," + orders.PhoneNum);
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
                    "，" + orders.Buyer + "," + orders.Cost + "," + orders.PhoneNum);
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
                    "，" + orders.Buyer + "," + orders.Cost + "," + orders.PhoneNum);
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
        public bool ChangeOrderByPhoneNum(string OldOrderPhoneNum, string NewOrderPhoneNum)
        {
            foreach (Order s in Order.orders)
            {
                if (s.PhoneNum == OldOrderPhoneNum)
                {
                    s.PhoneNum = NewOrderPhoneNum;
                    return true;
                }

            }
            return false;
        }
        public bool IsNumber(string s)
        {
            foreach (Order str in Order.orders)
            {
                if(str.Number==s)
                {
                    return false;
                }
            }
            string pattern="^20[0-9]{2}(0[1-9]|1[012])(0[1-9]|[12][0-9]|3[01])[0-9]{3}$";
            try
            {
                if (Regex.IsMatch(s, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool IsPhoneNum(string s)
        {
            string pattern = "^1[0-9]{10}$";
            try
            {
                if (Regex.IsMatch(s, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
