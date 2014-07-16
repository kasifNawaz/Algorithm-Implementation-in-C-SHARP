using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    class FactorialCL
    {
        private int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return factorial(n - 1) * n;
            }
        }
        static void Main(string[] args)
        {
            FactorialCL factorial = new FactorialCL();
            Console.Write(factorial.factorial(4));
            Console.ReadKey();
        }
    }
}
