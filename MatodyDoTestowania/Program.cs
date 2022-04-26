using System;

namespace MetodyDoTestowania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class Metody
        {
            public static int Sum(params int[] array)
            {
                int counter = 0;
                foreach (var item in array)
                {
                    counter += item;
                }
                return counter;
            }
        }
    }
}
