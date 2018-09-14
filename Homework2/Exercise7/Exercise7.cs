using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Random Array:");
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                array[i] = rd.Next(0,1000);
                Console.Write(array[i].ToString()+" ");
                System.Threading.Thread.Sleep(15);
            }
            int max = array[0], min = array[0], length = array.Length,sum=0 ;
            for(int i=0;i<length;i++)
            {
                if(array[i]>max)
                { max = array[i]; }
                if (array[i] <min )
                { min = array[i]; }
                sum += array[i];
            }
            double avg = sum / length;
            Console.WriteLine("\n"+"Max: " + max + " Min: " + min + " Average: " + avg + " Sum:" + sum);
            Console.ReadLine();                      
        }
    }
}
