using System;
using System.Collections.Generic;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 10;
            int b = a;
            a++;
            Console.WriteLine($"a = {a}");//11
            Console.WriteLine($"b = {b}");//10

            int[] t1 = new int[] { 10, 20 };
            var t2 = t1;
            t1[0] = 100;
            t1[1] = 200;
            Console.WriteLine($"t1 = {t1[0]} {t1[1]}");//100 200
            Console.WriteLine($"t2 = {t2[0]} {t2[1]}");//100 200

            Console.WriteLine("========================");

            int x = 5;
            Console.WriteLine($"now number is {x}");//5
            AddOne(x);
            Console.WriteLine($"now number is {x}");//5

            List<int> list = new();
            Console.WriteLine($"amount of elements {list.Count}");//0
            AddOneToList(list);
            Console.WriteLine($"amount of elements {list.Count}");//1
        }
        private static void AddOne(int a)
        {
            a++;
        }
        private static void AddOneToList(List<int> list)
        {
            list.Add(1);
        }
    }
}
