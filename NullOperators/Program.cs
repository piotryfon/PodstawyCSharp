using System;
using System.Collections.Generic;

namespace NullOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Piotr";
            string defaultName = name ?? "Stanger"; 
            Console.WriteLine(defaultName);


            List<int> numbers = null;

            (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5


            int? a = null;

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5 0
            Console.WriteLine(a);  // output: 0

            numbers?.Clear();
            Console.WriteLine(numbers);
        }
    }
}
