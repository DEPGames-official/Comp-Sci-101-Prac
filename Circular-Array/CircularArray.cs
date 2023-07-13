using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Circular_Array
{
    public class CircularArray<T>
    {
        T[] array;
        int head;
        int tail;

        public CircularArray(int size)
        {
            array = new T[size];
            head = 0;
            tail = 0;
        }

        public void Add(T value)
        {
            array[tail] = value;
            tail = (tail + 1) % array.Length;
        }

        public T Remove()
        {
            var type = array[head];
            array[head] = default(T);
            head = (head + 1) % array.Length;
            return type;
        }

        public T[] PrintAvailable()
        {
            return array;
        }
    }
}