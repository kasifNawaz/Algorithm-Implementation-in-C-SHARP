using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class BinarySearch
    {
        private int Search(int x, int[] nums, int low, int heigh)
        {
            if (low > heigh)
            {
                return -1;
            }
            int mid = (low + heigh) / 2;
            int item = nums[mid];
            if (item == x)
            {
                return mid;
            }
            else if (x < item)
            {
                return Search(x, nums, low, mid - 1);
            }
            else if (x > item)
            {
                return Search(x, nums, mid - 1, heigh);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] Coll = { 42, 47, 54, 4, 7, 87, 4, 25, 7, 4, 35, 4, 7, 4, 9, 14, 200, 75, 45 };

            BinarySearch binarySearch = new BinarySearch();
            Console.Write(binarySearch.Search(200, Coll, 0, Coll.Length));
            Console.ReadKey();
        }
    }
}
