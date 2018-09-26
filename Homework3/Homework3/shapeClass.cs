using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class triangle : ShapeFactory, Shape
    {
        double Bottom, Hight;
        public triangle()
        {
            Bottom = 0;
            Hight = 0;
        }
        public triangle(double bottom,double hight)
        {
            Bottom = bottom;
            Hight = hight;
        }        
        public double getArea()
        {
            return (Hight * Bottom) / 2;
        }

    }
    class circle : ShapeFactory, Shape
    {
        double R;
        public circle(double r=0)
        {
            R = r;
        }
        public double getArea()
        {
            return R * R * Math.PI;
        }
    }
    class rectangle : ShapeFactory, Shape
    {
        double Length, Width;
        public rectangle(double length=0,double width=0)
        {
            Length = length;
            Width = width;
        }
        /*public void draw(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            for (int i = 1; i < y - 1; i++)
            {
                Console.Write("*");
                for (int j = 1; j < x - 1; j++) { Console.Write(" "); }
                Console.Write("*");
            }
            Console.Write("\n");
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
        }*/
        public double getArea()
        {
            return Length * Width;
        }
    }
    class square : ShapeFactory, Shape
    {
        double Edge;
        public square(double edge=0)
        {
            Edge = edge;
        }
        public double getArea()
        {
            return Edge * Edge;
        }
    }
}
