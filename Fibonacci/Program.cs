using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        private int GenerateFib(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            }
            return GenerateFib(n - 1) + GenerateFib(n - 2);
        }

        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
            Console.Write(fibonacci.GenerateFib(4));
            Console.ReadKey();

        }
    }
}
