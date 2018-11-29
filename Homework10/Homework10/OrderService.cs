using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OrderManagement
{
    class OrderService
    {
        public void Add(Order order)
        {
            using (var db = new OrderDataBase())
            {
                db.Order.Add(order);
                //db.Order.Attach(order);
                //db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(String orderId)
        {
            using (var db = new OrderDataBase())
            {
                var order = db.Order.Include("Items").SingleOrDefault(o => o.OrderId == orderId);
                db.GoodsItem.RemoveRange(order.Items);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            using (var db = new OrderDataBase())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.Items.ForEach(
                    item => db.Entry(item).State = EntityState.Modified);
                db.SaveChanges();
            }
        }

        public Order GetOrder(String Id)
        {
            using (var db = new OrderDataBase())
            {
                return db.Order.Include("Items").
                  SingleOrDefault(o => o.OrderId == Id);
            }
        }

        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDataBase())
            {
                return db.Order.Include("items").ToList<Order>();
            }
        }


        public List<Order> QueryByCustormer(String custormer)
        {
            using (var db = new OrderDataBase())
            {
                return db.Order.Include("items")
                  .Where(o => o.Customer.Equals(custormer)).ToList<Order>();
            }
        }

        public List<Order> QueryByGoods(String product)
        {
            using (var db = new OrderDataBase())
            {
                var query = db.Order.Include("items")
                  .Where(o => o.Items.Where(
                    item => item.Product.Equals(product)).Count() > 0);
                return query.ToList<Order>();
            }
        }
    }
}
