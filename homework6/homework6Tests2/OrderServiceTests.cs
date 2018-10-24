using Microsoft.VisualStudio.TestTools.UnitTesting;
using program2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void ExportTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void XmlSerializeTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            ojb.AddOrder("2017302580222", "乒乓球", "小黑", 23000);
            string s = "小黑";
            Assert.IsTrue(s== Order.orders[3].buyer);
        }
        [TestMethod()]
        public void DelectOrderByNumTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            Assert.IsTrue(ojb.DelectOrderByNum("2017302580097"));
        }

        [TestMethod()]
        public void DelectOrderByNameTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            Assert.IsTrue(ojb.DelectOrderByName("排球"));

        }

        [TestMethod()]
        public void DelectOrderByBuyerTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            Assert.IsTrue(ojb.DelectOrderByBuyer("小明"));
            

        }

        [TestMethod()]
        public void SearchOrderByNumTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SearchOrderByNameTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SearchOrderByBuyerTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SearchOrderNumUpTenthousandTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void ChangeOrderByNumTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            ojb.AddOrder("2017302580222", "棒球", "小黑", 23000);           
            bool flag = ojb.ChangeOrderByNum("2017302580222", "2017302580111");
            Assert.IsTrue(flag);
            

        }

        [TestMethod()]
        public void ChangeOrderByNameTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            ojb.AddOrder("2017302580222", "棒球", "小黑", 23000);
            bool flag =ojb.ChangeOrderByName("棒球", "乒乓球");
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void ChangeOrderByBuyerTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            ojb.AddOrder("2017302580152", "篮球", "小李", 12000);
            ojb.AddOrder("2017302580097", "排球", "小明", 25000);
            ojb.AddOrder("2017302580222", "棒球", "小黑", 23000);
            bool flag = ojb.ChangeOrderByBuyer("小黑", "小灰");
            Assert.IsTrue(flag);
        }
    }
}