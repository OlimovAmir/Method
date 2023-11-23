using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
     class MethodExample
    {
        /// <summary>
        /// Воврашает сумму двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }
        static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            double result = Sum(3.5, 3.6);
            Console.WriteLine(result);
        }
    }
}
