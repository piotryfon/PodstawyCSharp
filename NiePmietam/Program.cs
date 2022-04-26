using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PolaFigur
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Cześć, policzmy pole trójkąta.");

            Thread.Sleep(2000);

            Console.WriteLine("Podaj długość podstawy.");
            var a = Console.ReadLine();
            Console.WriteLine("Podaj wysokość.");
            var h = Console.ReadLine();
            Console.WriteLine("Trwa obliczanie...");

            await DelayCalc(double.Parse(a), double.Parse(h));
           
            Console.ReadKey();
        }
        public async static Task DelayCalc(double a, double h)
        {
            var rezultat = Pola.PoleTrojkata(a, h);
            await Task.Delay(3000);
            Console.WriteLine(rezultat);
        }
        class Pola
        {
            public static double PoleTrojkata(double a, double h)
            {
                return (a * h) / 2;
            }
        }
    }
}
