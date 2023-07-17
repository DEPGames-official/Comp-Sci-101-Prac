using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quick_Sort
{
    public class QuickSort
    {
        public int[] Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                var partitionIndex = Partition(arr, low, high);

                Sort(arr, low, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, high);

            }

            return arr;



        }

        int Partition(int[] arr, int low, int high)
        {
            int lowIndex = low - 1;
            int pivot = arr[high];

            for (int i = low; i <= high; i++)
            {
                if (arr[i] < pivot)
                {
                    lowIndex++;
                    (arr[lowIndex], arr[i]) = (arr[i], arr[lowIndex]);



                }

            }

            (arr[lowIndex + 1], arr[high]) = (arr[high], arr[lowIndex + 1]);

            return lowIndex + 1;
        }
    }
}