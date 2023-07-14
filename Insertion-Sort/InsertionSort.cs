using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    public class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            int num;
            for (int i = 1; i < arr.Length; i++)
            {
                num = i;
                for (int x = i; x > 0; x--)
                {

                    if (arr[x] < arr[x - 1])
                    {
                        (arr[x], arr[x - 1]) = (arr[x - 1], arr[x]);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            return arr;

        }
    }
}