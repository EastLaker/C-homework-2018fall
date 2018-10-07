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
                            server.addOrder();
                            break;
                        case 2:
                            Console.WriteLine("Please input the ID of the order you want to delete:");
                            server.delOrder(int.Parse(Console.ReadLine()));
                            break;
                        case 3:
                            server.displayAll();
                            break;
                        case 4:
                            Console.WriteLine("Please input the ID of the order you want to change");
                            server.changeOrder(int.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            server.searchOrder();
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
