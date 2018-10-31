/*
第六次作业:
1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
2、为OrderService类的各个Public方法，编写测试用例，使用合法和非法的输出数据进行测试。
👉👉👉截止时间10月24日21:00👈👈👈
*/
/*
 第七次作业
为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单等功能。
要求：
（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
（2）主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
（3）尽量通过数据绑定来实现功能。 注：订单明细可以设置DataMember来绑定。
👉👉👉截止时间10月31日21:00👈👈👈
 */

using System;
//using System.Xml.Serialization;
using System.IO;

namespace OrderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter writer = new StreamWriter("Order.xml");
            TextReader reader = new StreamReader("importOrder.xml");
            Console.WriteLine("Welcome to order management system!");
            OrderService server = new OrderService();
            while (true)
            {
                try
                {
                    Console.Write("0.help \n1.add order\n2.delete order\n3.show orders\n4.change order information\n5.Search order\n6.Save to Xml\n7.import order\n");
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
                            //server.SearchOrder();
                            break;
                        case 6:
                            server.ExportOrder(server,writer);                            
                            break;
                        case 7:
                            server.Import(reader);
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
