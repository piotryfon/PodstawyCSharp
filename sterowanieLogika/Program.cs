using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sterowanieLogika
{
    class Program
    {
        static void Main(string[] args)
        {
            if(1>2 || 2 != 2 && 3 > 0 || 1 < 4)
            {
                Console.WriteLine("Tak");
            }

            Console.ReadKey();
        }
    }
}
