/*
* 第五次作业:
1、对上次作业的订单程序，使用LINQ语句，（1）实现按照商品名称、客户等字段查询订单的功能;（2） 查询订单金额大于1万元的订单。
2、第五章课后第15题（改进例5-31的画树程序）。
👉👉👉截止时间下周三晚9:00👈👈👈
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to order management system!");
            OrderService server = new OrderService();
            while (true)
            {
                try
                {
                    Console.Write("0.help \n1.add order\n2.delete order\n3.show orders\n4.change order information\n5.Search order\n");
                    int Controler = int.Parse(Console.ReadLine());
                    switch (Controler)
                    {
                        case 0:
                            break;
                        case 1:
                            server.AddOrder();
                            break;
                        case 2:
                            Console.WriteLine("Please input the ID of the order you want to delete:");
                            server.DelOrder(int.Parse(Console.ReadLine()));
                            break;
                        case 3:
                            server.DisplayAll();
                            break;
                        case 4:
                            Console.WriteLine("Please input the ID of the order you want to change");
                            server.ChangeOrder(int.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            server.SearchOrder();
                            break;
                        default:
                            break;
                    }
                }
                catch { }
            }
        }
    }
}
