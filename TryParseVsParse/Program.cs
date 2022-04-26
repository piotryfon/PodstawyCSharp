using System;

namespace TryParseVsParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test TryParse. Wpisz cyfrę");
            string odp = Console.ReadLine();
            int tp;
            bool b = int.TryParse(odp, out tp);
            Console.WriteLine($"Wynik TryParse {b} {tp}"); 

            Console.WriteLine("");

            Console.WriteLine("Test Parse. Wpisz cyfrę");
            string odp1 = Console.ReadLine();
            int p;
            try
            {
                p = int.Parse(odp1);
                Console.WriteLine($"Wynik Parse {p}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Nie można przekonwertować -> {odp1}. {e.Message}");
            }
        }
    }
}
