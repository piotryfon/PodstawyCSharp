using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeClasses
{
    public class SimpleMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double SumAllParams(params double[]arr)
        {
            double sum = 0;
            foreach (double item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
