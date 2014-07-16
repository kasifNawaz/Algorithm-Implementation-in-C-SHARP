using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteForce
{
    class Bforce
    {
        private int BruteSearch(string T, string P)
        {
            int n = T.Length;
            int m = P.Length;
            for (int i = 0; i <= n - m; ++i)
            {
                int j = 0;
                while (j < m && P[j] == T[j+i])
                {
                    ++j;
                }
                if (j == m)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            
            Bforce bforce = new Bforce();
            string t = "Brute Force string Matching";
            string p = "string";
            bforce.BruteSearch(t,p);
            Console.ReadKey();

        }
    }
}
