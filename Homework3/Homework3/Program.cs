using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 第三次作业
（1）学习设计模式的基础知识，建议看https://gof.quanke.name/，了解面向对象的各种设计原则。
（2）写一个程序，使用简单工厂模式创建4个图形（三角形、圆形、正方形、长方形），然后计算每个图形的面积。
*/


namespace Homework3
{
    interface Shape
    {        
        double getArea();
    }
    class ShapeFactory
    {
        Shape objectShape;
        public Shape getObject(string chooser)
        {
            switch(chooser)
            {
                case "circle":
                    Console.WriteLine("Please input the radius of the circle:");
                    double radius = double.Parse(Console.ReadLine());
                    objectShape = new circle(radius);
                    Console.WriteLine("Area : "+objectShape.getArea());
                    break;
                case "square":
                    Console.WriteLine("Please input the edge of the square:");
                    double edge = double.Parse(Console.ReadLine());
                    objectShape = new square(edge);
                    Console.WriteLine("Area : " + objectShape.getArea());
                    break;
                case "triangle":
                    Console.WriteLine("Please input the Bottom of the circle:");
                    double bottom= double.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the Height of the circle:");
                    double hight= double.Parse(Console.ReadLine());
                    objectShape = new triangle(bottom,hight);
                    Console.WriteLine("Area : " + objectShape.getArea());
                    break;
                case "rectangle":
                    Console.WriteLine("Please input the Length of the circle:");
                    double length= double.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the Width of the circle:");
                    double width= double.Parse(Console.ReadLine());
                    objectShape = new rectangle(length,width);
                    Console.WriteLine("Area : " + objectShape.getArea());
                    break;
                default:
                    Console.WriteLine("Invaild Input!");break;
            }
            return objectShape;
        }
    }
    
    


    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory fac = new ShapeFactory();
            string chooser;
            Console.WriteLine("Please choose a shape(circle,square,triangle or rectangle):");
            chooser = Console.ReadLine();
            fac.getObject(chooser);
            Console.ReadLine();
        }
    }
}
