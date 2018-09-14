using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
6.输出用户数据的所有素数因子
7.求一个整数数组的最大值，最小值，平均值和所有数组元素的和
9.用“埃氏筛法”求2~100以内的素数（先去掉2的倍数，再去掉3的倍数，再去掉4的倍数...最后剩下的就是素数）
*/
namespace Exercise6
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an intger: ");
            int target=int.Parse(Console.ReadLine());
            //int[] primes=new int[1000];
            int i = 2;
            while(target>=i)
            {
                if(target%i==0)
                {
                    target = target / i;
                    Console.Write(i + " ");
                }
                if (target % i != 0)
                {
                    i++;
                }
            }
            Console.ReadLine();
        }
    }
}

