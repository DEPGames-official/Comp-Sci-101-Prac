namespace Merge_Sort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] Numarr = { 38, 27, 43, 3, 9, 82, 10, 15 };

            MergeSort sortNums = new MergeSort();
            int[] sortedNums = sortNums.Sort(Numarr);

            foreach (int i in sortedNums)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}


