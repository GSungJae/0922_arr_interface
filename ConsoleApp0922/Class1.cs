using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class Class1
    {
        //static int Sum(int start,int end)
        //{
        //    int total=0;
        //    for (int i = start; i <= end; i++)
        //        total = total + i;
        //    return total;
        //}
        static void Sum(int step, int start = 1, int end=100)
        {
            int total = 0;
            for (int i = start; i <= end; i++)
                total = total + i;
            Console.WriteLine(total);
        }
        static void Main()
        {
            //Console.Write("최소값 : ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("최대값 : ");
            //int end = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Sum(start, end));
            //Console.WriteLine(Sum(end));
            Sum(1, 100, 1);
            Sum(1, end:100);
            Sum(1, 90);
            Sum(1);
        }
    }
}
