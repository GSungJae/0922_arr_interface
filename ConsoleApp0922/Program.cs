using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
    class Program
    {
        static int  Sqr(int x)
        {
            x = x * x;
            return x;
        }
        static void Sqr(ref int x)
        {
            x = x * x;
        }
        static void GetName(out string name, out int id)
        {
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Id : ");
            id = int.Parse(Console.ReadLine());
        }
        static void PrintIntParams(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+ " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a=3;
            a = Sqr(a);
            Console.WriteLine("value: {0}", a);

            int b = 3;
            Sqr(ref b);
            Console.WriteLine("ref : {0}", b);

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out: {0} {1}", name, id);

            PrintIntParams(1, 2, 3, 4);

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(myIntArray);

            PrintIntParams();

            
        }
    }
}
