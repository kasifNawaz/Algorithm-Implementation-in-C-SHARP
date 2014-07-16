using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class QuicksortCL
    {
        private void Quicksort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int piv = (l + r) / 2;
                int i = l, j = r;

                while (i <= j)
                {
                    while (arr[i] < arr[piv])
                    {
                        i++;
                    }

                    while (arr[j] > arr[piv])
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        swap(ref arr[i], ref arr[j]);
                        i++;
                        j--;
                    }
                }

                if (i < r)
                {
                    Quicksort(arr, i, r);
                }
                if (j > l)
                {
                    Quicksort(arr, l, j);
                }

            }
        }

        private void swap(ref int p1, ref int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }

        static void Main(string[] args)
        {
            QuicksortCL quicksortCL = new QuicksortCL();
            int[] arr = { 14, 2, 7, 4, 9, 2, 0, 7, 3, 1, 9, 5, 4, 6, 7, 0, 1, 6 };

            quicksortCL.Quicksort(arr, 0, arr.Length-1);
        }
    }
}
