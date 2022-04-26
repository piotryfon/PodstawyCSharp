using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var res1 = Factorial(3);
            Console.WriteLine(res1);
            var res2 = FactorialRec(3);
            Console.WriteLine(res2);
        }
        public static double Factorial(long input)
        {
            long result = 1;
            for (int i = 1; i <= input; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static double FactorialRec(long input)
        {
            if(input == 1)
            {
                return 1;
            }
            return input * FactorialRec(input - 1); 
        }
    }
}
