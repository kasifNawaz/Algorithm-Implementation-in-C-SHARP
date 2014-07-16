using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSo
{
     public class SelectionSort
    {
        private int[] Sort(int[] nums)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                int index_min = x;

                for (int i = index_min + 1; i < nums.Length; i++)
                {
                    if (nums[index_min] > nums[i])
                    {
                        index_min = i;
                    }
                }
                int temp = nums[index_min];
                nums[index_min] = nums[x];
                nums[x] = temp;
            }
            return nums;

        }
        static void Main(string[] args)
        {
            SelectionSort sel = new SelectionSort();
            int[] Coll = { 42, 47, 54, 4, 7, 87, 4, 25, 7, 4, 35, 4, 7, 4, 9, 14, 200, 75, 45 };
            int[] numsort = sel.Sort(Coll);
            Console.ReadKey();
           
        }
    }
}
