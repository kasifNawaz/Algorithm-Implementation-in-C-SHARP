using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSo
{
    class BubbleSort
    {
        private void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length - 2; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        private void Swap(ref int p1, ref int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            int[] arr = { 4, 8, 7, 6, 2, 7, 4, 9, 1, 0, 5, 4, 6, 6, 8, 4 };
            bubbleSort.Sort(arr);
            Console.ReadKey();
        }
    }
}
