using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleMath sm = new SimpleMath();
            int res = sm.Add(100, 200);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
