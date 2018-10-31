using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace OrderConsole
{
    [Serializable]
    public class OrderService 
    {
        XmlSerializer serializer;
        public List<Order> myOrder = new List<Order>();
        public OrderService()
        {
            serializer = new XmlSerializer(typeof(OrderService));
            
        }
        public OrderService(OrderService service)
        {
            myOrder = service.myOrder;
        }
        public void AddOrder()
        {
            
            Order newOrder = new Order(0);           
            myOrder.Add(newOrder);

        }
        public void AddOrder(Order order)
        {
            myOrder.Add(order);
        }
        public void DelOrder(int index)
        {
            if (index >= 0 && index < myOrder.Count())
            { myOrder.RemoveAt(index); }
            else
            { Console.WriteLine("Invaild Index"); }           
        }
        //public void SearchOrder()
        //{
        //    Console.Write("a.Search by ID\nb.Search by client's name\nc.Search by commodity's name(商品名)\nd.Search by price\n");
        //    char switcher;
        //    switch (switcher = char.Parse(Console.ReadLine()))
        //    {
        //        case 'a':
        //            int index;
        //            Console.WriteLine("Please input the ID of an order:");
        //            index = int.Parse(Console.ReadLine());
        //            if (index >= 0 && index < myOrder.Count())
        //            { DisplayOrder(index); }
        //            else
        //            { Console.WriteLine("Index out of range."); }
        //            break;
        //        case 'b':
        //            Console.WriteLine("Please input the client's name :");
        //            string cName = Console.ReadLine();
        //            var m2 = from n in this.myOrder where n.client == cName select n;
        //            foreach (var n in m2)
        //            {
        //                DisplayOrder(n);
        //            }
        //            break;
        //        case 'c':
        //            Console.WriteLine("Please input the commodity's name :");
        //            string sname = Console.ReadLine();
        //            var m3 = from n in this.myOrder where n.name == sname select n;
        //            foreach (var n in m3)
        //            {
        //                DisplayOrder(n);
        //            }
        //            break;
        //        case 'd':
        //            Console.WriteLine("You want to search the items with the price over :? RMB");
        //            float sprice = float.Parse(Console.ReadLine());
        //            myOrderDetail.FindAll(mlist =>
        //            {
        //                if (mlist.price > sprice)
        //                {
        //                    DisplayOrder(mlist);
        //                    return true;
        //                }
        //                else
        //                    return false;
        //            });
        //            var m4 = from n in this.myOrder where n.price >= sprice select n;
        //            foreach (var n in m4)
        //            {
        //                DisplayOrder(n);
        //            }
        //            break;
        //    }
        //}
        public void ChangeOrder(int index)
        {
            if (index >= 0 && index < myOrder.Count())
            {
                myOrder.RemoveAt(index);
                myOrder.Insert(index, new Order(0)) ;
                DisplayOrder(myOrder[index]);
            }
            else
            { Console.WriteLine("Invaild Index"); }
        }
        public void DisplayAll()
        {
            try
            {
                int i = 0;
                foreach (Order x in myOrder)
                {
                    Console.Write("Order ID: "+ i + " " );
                    DisplayOrder(x);
                    i++;
                }
            }
            catch
            { Console.WriteLine("Empty List"); }
        }
        public void DisplayOrder(int OrderID)
        {
            if (OrderID >= 0 && OrderID < myOrder.Count())
            {
                Console.Write("name: " + myOrder[OrderID].Client +
                        "  price: " + myOrder[OrderID].TotalPrice );
            }
            else
            { Console.WriteLine("Invaild Index"); }
        }
        public void DisplayOrder(Order temp)
        {
            Console.Write("  client: "+temp.Client+
                        "  price: " + temp.TotalPrice +"\n");
        }
        public void ExportOrder(OrderService obj,TextWriter writer)
        { 
            serializer.Serialize(writer, obj);
            
        }
        public void Import(TextReader reader)
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader));
            this.myOrder = temp.myOrder;
            
        }
    }
}
