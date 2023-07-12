using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    public class BubbleSort
    {
        public int[] Bubble_Sort(int[] arr)
        {
            //Loop through array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int x = 0; x < arr.Length - 1; x++)
                {
                    //Check if current number is larger than number on the right
                    if (arr[x] > arr[x + 1])
                    {
                        //Swap the numbers around
                        (arr[x], arr[x + 1]) = (arr[x + 1], arr[x]);
                    }
                }

            }

            return arr;
        }
    }
}