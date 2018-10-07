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

        public void addOrder()
        {
            
            OrderDetails newOrder = new OrderDetails();
            //newOrder.stuffID = myOrderDetail.Count();
            myOrderDetail.Add(newOrder);

        }
        public void delOrder(int index)
        {
            if (index >= 0 && index < myOrderDetail.Count())
            { myOrderDetail.RemoveAt(index); }
            else
            { Console.WriteLine("Invaild Index"); }           
        }
        public void searchOrder()
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
                { displayOrder(index); }
                else
                { Console.WriteLine("Index out of range."); }
                    break;
                case 'b':                   
                    Console.WriteLine("Please input the client's name :");
                    string cName=Console.ReadLine();
                    myOrderDetail.FindAll(mlist =>
                    {
                        if (mlist.client == cName)
                        {
                            displayOrder(mlist);
                            return true;
                        }
                        else
                            return false;
                    });
                    break;
                case 'c':
                    Console.WriteLine("Please input the commodity's name :");
                    string sname = Console.ReadLine();
                    myOrderDetail.FindAll(mlist =>
                    {
                        if (mlist.name == sname)
                        {
                            displayOrder(mlist);
                            return true;
                        }
                        else
                            return false;
                    });
                    break;
                case 'd':
                    Console.WriteLine("Please input the client's name :");
                    float sprice = float.Parse(Console.ReadLine());
                    myOrderDetail.FindAll(mlist =>
                    {
                        if (mlist.price == sprice)
                        {
                            displayOrder(mlist);
                            return true;
                        }
                        else
                            return false;
                    });
                    break;
            }
        }
        public void changeOrder(int index)
        {
            if (index >= 0 && index < myOrderDetail.Count())
            {
                myOrderDetail.RemoveAt(index);
                myOrderDetail.Insert(index, new OrderDetails()) ;
                displayOrder(myOrderDetail[index]);
            }
            else
            { Console.WriteLine("Invaild Index"); }
        }
        public void displayAll()
        {
            try
            {
                int i = 0;
                foreach (OrderDetails x in myOrderDetail)
                {
                    Console.Write("Order ID: "+ i + " " );
                    displayOrder(x);
                    i++;
                }
            }
            catch
            { Console.WriteLine("Empty List"); }
        }
        public void displayOrder(int OrderID)
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
        public void displayOrder(OrderDetails temp)
        {
            Console.Write("name: " + temp.name +
                        "  client: "+temp.client+
                        "  price: " + temp.price +
                        "  number: " + temp.number+"\n");
        }
    }
}
