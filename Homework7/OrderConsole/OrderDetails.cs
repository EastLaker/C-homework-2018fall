using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderConsole
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails(int i)
        {
            int number;
            string name;
            float price;            
            Console.WriteLine("Please input the commodity's name(商品名):");
            name = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("Please input the number:");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                { Console.WriteLine("Wrong Input! Please input an inter!"); }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Please input the price(RMB):");
                    price = float.Parse(Console.ReadLine());
                    break;
                }
                catch
                { Console.WriteLine("Wrong Input! Please input an float number!"); }
            }
            this.name = name;           
            this.price = price;
            this.number = number;
        }
        public OrderDetails(OrderDetails order)
        {
            name = order.name;            
            price = order.price;
            number = order.number;
        }
        public OrderDetails(string Name,int Number,float Price)
        {
            name = Name;            
            price = Price;
            number = Number;
        }
        public OrderDetails()
        {}
        public string name
        { get; set; }        
        public float price
        { get; set; }
        public int number
        { get; set; }
    }
}
