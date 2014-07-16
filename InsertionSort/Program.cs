using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class InsertionCL
    {
        private void Sort(int[] arr)
        {
            int i, j, key;
            for (i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                for (j = i - 1; j > 0 && key < arr[j]; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = key;
            }
          
        }

        static void Main(string[] args)
        {
            InsertionCL insertionCL = new InsertionCL();
            int[] arr = { 14, 2, 7, 4, 9, 2, 0, 7, 3, 1, 9, 5, 4, 6, 7, 0, 1, 6 };

            insertionCL.Sort(arr);
        }
    }
}
