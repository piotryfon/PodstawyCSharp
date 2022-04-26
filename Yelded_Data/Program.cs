using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yielded_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetData();
            foreach (var item in data)
            {
                Console.WriteLine($"Main element {item}");
                if (item > 5) 
                    break;
            }

            var data2 = GetYeldedData();
            foreach (var item in data2)
            {
                Console.WriteLine($"Main element yield {item}");
                if (item > 5) 
                    break;
            }

            Console.ReadKey();
        }


        public static IEnumerable<int> GetData()
        {
            Console.WriteLine("GetData start");
            var result = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"GetData element {i}");
                result.Add(i);
            }
            Console.WriteLine("GetData end");
            return result;
        }

        public static IEnumerable<int> GetYeldedData()
        {
            Console.WriteLine("GetiYeldedData start");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"GetYieldedData element {i}");
                yield return i; // dzięki yield zwracamy iterator z pętli
                //if (i % 2 == 0) 
                //    yield break;
            }
            Console.WriteLine("GetiYeldedData start");
        }
    }
}
