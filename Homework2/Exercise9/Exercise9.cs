using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            //初始化数组
            int[] array = new int[99];
            for(int i = 0; i<99; i++ )
            {
                array[i] = i + 2;
            }
            //筛除非素数
            for(int j = 2; j <= 10; j++ )
            {
                for(int i=j ; i<99; i++)
                {
                    if (array[i] % j == 0)
                        array[i] = 0;
                }
            }
            //打印结果
            Console.WriteLine("Prime Numbers under 100 :");
            for (int i = 0; i < 99; i++)
            {
                if (array[i] != 0)
                    Console.Write(array[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
