using System;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int suma = Sum(new int[]{ 2, 4, 1});
            Console.WriteLine(suma);
            int suma2 = Sum2(3, 2, 1);
            Console.WriteLine(suma2);
            int suma3 = Sum2(new int[]{ 20, 40, 10 });
            Console.WriteLine(suma3);
        }
        public static int Sum(int[]numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
        public static int Sum2(params int[] numbers) 
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
