using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderConsole
{
    public class OrderDetails:Order
    {
        public OrderDetails()
        {
            int number;
            string name, client;
            float price;
            Console.WriteLine("Please input the client's name:");
            client = Console.ReadLine();
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
                    Console.WriteLine("Please input the price:");
                    price = float.Parse(Console.ReadLine());
                    break;
                }
                catch
                { Console.WriteLine("Wrong Input! Please input an float number!"); }
            }
            this.name = name;
            this.client = client;
            this.price = price;
            this.number = number;
        }
        public OrderDetails(string Name,int Number,float Price)
        {
            name = Name;
            price = Price;
            number = Number;
        }
        public string name
        { get; set; }
        public string client
        { get; set; }
        public float price
        { get; set; }
        public int number
        { get; set; }
        public int stuffID
        { get; set; }
    }
}
