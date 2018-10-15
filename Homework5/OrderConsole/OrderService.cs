using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderConsole
{
    class OrderService :Order
    {
        List<OrderDetails> myOrderDetail = new List<OrderDetails>();

        public void AddOrder()
        {
            
            OrderDetails newOrder = new OrderDetails();
            //newOrder.stuffID = myOrderDetail.Count();
            myOrderDetail.Add(newOrder);

        }
        public void DelOrder(int index)
        {
            if (index >= 0 && index < myOrderDetail.Count())
            { myOrderDetail.RemoveAt(index); }
            else
            { Console.WriteLine("Invaild Index"); }           
        }
        public void SearchOrder()
        {
            Console.Write("a.Search by ID\nb.Search by client's name\nc.Search by commodity's name(商品名)\nd.Search by price\n");
            char switcher;
            switch (switcher=char.Parse(Console.ReadLine()))
            {
                case 'a':
                int index;
                Console.WriteLine("Please input the ID of an order:");
                index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < myOrderDetail.Count())
                { DisplayOrder(index); }
                else
                { Console.WriteLine("Index out of range."); }
                    break;
                case 'b':                   
                    Console.WriteLine("Please input the client's name :");
                    string cName=Console.ReadLine();
                    var m2 = from n in this.myOrderDetail where n.client==cName select n;
                    foreach (var n in m2)
                    {
                        DisplayOrder(n);
                    }
                    break;
                case 'c':
                    Console.WriteLine("Please input the commodity's name :");
                    string sname = Console.ReadLine();
                    var m3 = from n in this.myOrderDetail where n.name==sname select n;
                    foreach (var n in m3)
                    {
                        DisplayOrder(n);
                    }
                    break;
                case 'd':
                    Console.WriteLine("You want to search the items with the price over :? RMB");
                    float sprice = float.Parse(Console.ReadLine());
                    //myOrderDetail.FindAll(mlist =>
                    //{
                    //    if (mlist.price > sprice)
                    //    {
                    //        DisplayOrder(mlist);
                    //        return true;
                    //    }
                    //    else
                    //        return false;
                    //});
                    var m4 = from n in this.myOrderDetail where n.price >= sprice select n;
                    foreach(var n in m4)
                    {
                        DisplayOrder(n);
                    }
                    break;
            }
        }
        public void ChangeOrder(int index)
        {
            if (index >= 0 && index < myOrderDetail.Count())
            {
                myOrderDetail.RemoveAt(index);
                myOrderDetail.Insert(index, new OrderDetails()) ;
                DisplayOrder(myOrderDetail[index]);
            }
            else
            { Console.WriteLine("Invaild Index"); }
        }
        public void DisplayAll()
        {
            try
            {
                int i = 0;
                foreach (OrderDetails x in myOrderDetail)
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
            if (OrderID >= 0 && OrderID < myOrderDetail.Count())
            {
                Console.Write("name: " + myOrderDetail[OrderID].name +
                        "  price: " + myOrderDetail[OrderID].price +
                        "  number: " + myOrderDetail[OrderID].number);
            }
            else
            { Console.WriteLine("Invaild Index"); }
        }
        public void DisplayOrder(OrderDetails temp)
        {
            Console.Write("name: " + temp.name +
                        "  client: "+temp.client+
                        "  price: " + temp.price +
                        "  number: " + temp.number+"\n");
        }
    }
}
