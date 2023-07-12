namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 52, 8, 12, 94, 26, 8, 5, 7 };

            BubbleSort sort = new BubbleSort();
            int[] sortedNumbers = sort.Bubble_Sort(numbers);
            foreach (int num in sortedNumbers)
            {
                System.Console.WriteLine(num);
                //System.Console.WriteLine(sortedNumbers.Length);
            }
        }
    }

}
