using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heap_Tree
{
    public class HeapTree
    {
        int[] heapArr;
        int heapSize;

        public HeapTree(int size)
        {
            heapArr = new int[size];
        }

        public void Add(int num)
        {

            heapArr[heapSize] = num;
            heapSize++;

            int index = heapSize - 1;


            while (index > 0 && heapArr[index] > heapArr[Parent(index)])
            {
                Swap(index, Parent(index));

                index = Parent(index);
            }
        }

        public void RemoveRoot()
        {
            if (heapSize == 0)
            {
                return;
            }

            int root = heapArr[0];
            heapArr[0] = heapArr[heapSize - 1];
            heapArr[heapSize - 1] = default;
            heapSize--;

            Heapify(0);

        }

        public void PrintTree()
        {
            foreach (int num in heapArr)
            {
                System.Console.WriteLine(num);
            }
        }

        void Heapify(int index)
        {
            int largest = index;
            int left = LeftChild(index);
            int right = RightChild(index);

            if (left < heapSize && heapArr[left] > heapArr[largest])
            {
                largest = left;
            }
            if (right < heapSize && heapArr[right] > heapArr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                Swap(largest, index);

                Heapify(largest);
            }

        }

        void Swap(int i, int j)
        {
            (heapArr[i], heapArr[j]) = (heapArr[j], heapArr[i]);
        }

        int Parent(int index)
        {
            return (index - 1) / 2;
        }

        int LeftChild(int index)
        {
            return (2 * index) + 1;
        }

        int RightChild(int index)
        {
            return (2 * index) + 2;
        }



    }
}