using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
     class MethodExample
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int result = Sum(1, 2);
            Console.WriteLine(result);
        }
    }
}
