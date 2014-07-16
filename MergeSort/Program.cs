using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSo
{
    class MergeCL
    {
        public void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int mid = (l + r)/2;
                MergeSort(arr, l, mid);
                MergeSort(arr, mid + 1, r);
                Merge(arr, l, mid, r);
            }
        }
        private void Merge(int[] arr, int l, int mid, int r)
        {
            int n1 = mid - l+1 ;
            int n2 = r - mid;

            int[] temp1 = new int[n1];
            int[] temp2 = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                temp1[i] = arr[i+l];
            }

            for (int j = 0; j <n2; j++)
            {
                temp2[j] = arr[j + mid+1];
            }
            {
                int i = 0;
                int j = 0;
                int k = l;

                while (i < n1 && j < n2)
                {
                    if (temp1[i] <= temp2[j])
                    {
                        arr[k] = temp1[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = temp2[j];
                        j++;
                    }
                    k++;
                }
                while (i < n1)
                {
                    arr[k] = temp1[i];
                    i++;
                    k++;
                }
                while (j < n2)
                {
                    arr[k] = temp2[j];
                    j++;
                    k++;
                }
            }
        }
        static void Main(string[] args)
        {
            MergeCL mergeSort = new MergeCL();
            int[] arr = { 14, 2, 7, 4, 9, 2, 0, 7, 3, 1, 9, 5, 4, 6, 7, 0, 1, 6 };

            mergeSort.MergeSort(arr, 0, arr.Length-1);
        }
    }
}
