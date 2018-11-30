using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public class OrderService
    {
        public void Add(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Add(order);
                db.SaveChanges();

            }
        }

        public void Delete(String orderId)
        {
            using (var db = new OrderDB())
            {
                var order = db.Order.Include("OrderItems").SingleOrDefault(o => o.Id == orderId);
                db.OrderItem.RemoveRange(order.OrderItems);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.OrderItems.ForEach(
                    item => db.Entry(item).State = EntityState.Modified);
                db.SaveChanges();
            }
        }

        //public bool IsOrderExist(string id)
        //{                        
        //    using (var db = new OrderDB())
        //    {
        //        bool flag;
        //        foreach (Order order in db.Order)
        //        {
        //            if(order.Id!=id)
        //            {
        //                flag = false;
        //            }
        //            else
        //            {
        //                flag = true;
        //                break;
        //            }
        //        }
        //        return flag;
        //    }
        //}
        public Order GetOrder(String Id)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("OrderItems").
                   SingleOrDefault(o => o.Id == Id);
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("Orderitems").ToList<Order>();
            }
        }


        //public List<Order> QueryByCustormer(String custormer)
        //{
        //    using (var db = new OrderDB())
        //    {
        //        return db.Order.Include("Orderitems")
        //          .Where(o => o.Customer.Equals(custormer)).ToList<Order>();
        //    }
        //}

        //public List<Order> QueryByGoods(String product)
        //{
        //    using (var db = new OrderDB())
        //    {
        //        var query = db.Order.Include("Orderitems")
        //          .Where(o => o.OrderItems.Where(
        //            item => item.Product.Equals(product)).Count() > 0);
        //        return query.ToList<Order>();
        //    }
        //}

    }
}
