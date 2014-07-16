using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HorSpool
{
    class HorSpoolCL
    {
        int[] t = new int[250];
        public void shifttable(char[] p)
        {
            int i, j, m;
            m = p.Length;
            for (i = 0; i < 250; i++)
                t[i] = m;
            for (j = 0; j < m - 1; j++)
                t[p[j]] = m - 1 - j;
        }
      public  int horspool(char[] src, char[] p)
        {
            int i, j, k, m, n;
            n = src.Length;
            m = p.Length;
            i = m - 1;
            while (i < n)
            {
                k = 0;
                while ((k < m) && (p[m - 1 - k] == src[i - k]))
                    k++;
                if (k == m)
                    return (i - m + 1);
                else
                    i += t[src[i]];
            }
            return -1;
        }
        static void Main(string[] args)
        {
            HorSpoolCL horSpoolCL = new HorSpoolCL();
            string p = "i am kasif reza nawaz";
            string t = "am";
            horSpoolCL.shifttable(t.ToCharArray());
           int x= horSpoolCL.horspool(p.ToCharArray(), t.ToCharArray());
           Console.Write(x);
           Console.ReadKey();

        }
    }
}
