/*
*第十次作业（最后一次:)：
*使用EF框架，将订单系统的OrderService中的增删改查方法，改为对MySQL数据库的操作，并调整原来订单系统的Winform代码，使这些操作正常工作。
*截止时间29号晚九点。
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            //orderService.Delete("001");

            List<GoodsItem> items = new List<GoodsItem>() {
                new GoodsItem("1", "Xbox", 10.0, 20),
                new GoodsItem("2", "PS4pro", 2.0, 100)
            };

            Order order = new Order("001", "Jack Ma", DateTime.Now, items);

            orderService.Add(order);

            Order order2 = new Order("001", "Pony Ma", DateTime.Now, items);
            orderService.Update(order2);


            List<Order> orders = orderService.QueryByCustormer("Pony Ma");
            orders.ForEach(
              o => Console.WriteLine($"{o.OrderId},{o.Customer}"));


        }
    }
    
}
