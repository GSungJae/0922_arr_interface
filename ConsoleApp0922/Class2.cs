using System;
using System.Linq;

namespace ConsoleApp0922
{
    class Class2
    {
        static void ChangeArray(int[] p)
        {
            p[0]++;
        }
        static int MyMax(int[] p)
        {
            int max = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if(max<p[i])
                    max = p[i];
            }
            return max;
        }
        static void Main()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            Console.WriteLine(arr1[0]);

            ChangeArray(arr1);
            Console.WriteLine(arr1[0]);

            int[] arr2 = new int[3] { 1, 2, 3 };
            Console.WriteLine(arr2[0]);

            ChangeArray((int[])arr2.Clone()); // deep copy - 원래의 값에 영향을 주지않음.
            Console.WriteLine(arr2[0]);
            int max = MyMax(arr2);
            Console.WriteLine(max);


            Console.WriteLine(arr2.Min());
            Console.WriteLine(arr2.Max());

            int[] target = new int[5];
            arr2.CopyTo(target, 2);
            PrintArray(target);
            Array.Copy(arr2, 0, target, 2, 3);
            // Array.Copy(arr2, target, 3);

            int[] arr3 = new int[10] { 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            PrintArray(arr3);

            Array.Sort((int[])arr3.Clone());
            PrintArray(arr3);
            Array.Reverse(arr3);
            PrintArray(arr3);

            string str = "adsasdasdfsdsdfa";
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str);
            // Console.WriteLine(str.Replace("sdf", "000000"));
            str = str.Replace("sdf", "000000");
            Console.WriteLine(str);

            int[,] s_arr = new int[2, 3]
            {
                { 1,2,3}, { 4,5,6}
            };

            Console.WriteLine(s_arr[1,2]);
            for(int i= 0;i<s_arr.GetLength(0);i++)
            {
                for (int k = 0; k < s_arr.GetLength(1); k++)
                    Console.Write(s_arr[i, k] + " ");
            }
            Console.WriteLine();
            foreach(int temp in s_arr)
                Console.Write(temp+" ");
        }

        private static void PrintArray(int[] target)
        {
            for (int i = 0; i < target.Length; i++)
                Console.Write(target.GetValue(i) + " ");
            Console.WriteLine("");
        }
        private static void PrintArray(int[,] target)
        {
            for (int i = 0; i < target.GetLength(0); i++)
                for (int k = 0; k < target.GetLength(1); k++)
                    Console.Write(target[i,k] + " ");
            Console.WriteLine("");
        }
    }
}
