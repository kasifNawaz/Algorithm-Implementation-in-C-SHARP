using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsExp
{
    class Fibonacci
    {
        public int Fib(int n)
        {
            if ((n==0) && (n==1))
            {
                return n;
            }
            else
            {
                return Fib()
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
