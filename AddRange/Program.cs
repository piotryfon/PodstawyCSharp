using System;
using System.Collections.Generic;

namespace AddRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new[] { 400, 500, 600 };
            List<int> list = new() { 100, 200, 300 };
            list.AddRange(arr);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            int c = list.Capacity;
            Console.WriteLine(c);

            int[] arr2 = new int[10];
            string[] strArr;
            strArr = new string[5];
            
        }
    }
}
