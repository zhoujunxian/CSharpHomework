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
        public void AddOrderTest()
        {
            OrderService ojb = new OrderService();
            ojb.AddOrder("2017302580175", "足球", "赵刚", 2000);
            Assert.Fail();
        }

        [TestMethod()]
        public void DelectOrderByNumTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DelectOrderByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DelectOrderByBuyerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchOrderByNumTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchOrderByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchOrderByBuyerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchOrderNumUpTenthousandTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ChangeOrderByNumTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ChangeOrderByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ChangeOrderByBuyerTest()
        {
            Assert.Fail();
        }
    }
}