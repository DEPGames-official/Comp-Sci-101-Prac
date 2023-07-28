using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircularArray
{
    /// <summary>
    /// Circular array with basic functions
    /// </summary>
    public class CircularArray<T>
    {
        T[] arr;
        int head;
        int tail;

        public CircularArray(int size)
        {
            arr = new T[size];
            head = 0;
            tail = 0;
        }

        //Adds to end of Array
        public void Add(T value)
        {
            arr[tail] = value;
            tail = (tail + 1) % arr.Length;
        }

        //Removes at front of array
        public T Remove()
        {
            T type = arr[head];
            arr[head] = default(T);
            head = (head + 1) % arr.Length;

            return type;
        }

        //Prints entire array regardless of head and tail position
        public void PrintArr()
        {
            foreach (T num in arr)
            {
                System.Console.WriteLine(num);
            }
        }
    }
}