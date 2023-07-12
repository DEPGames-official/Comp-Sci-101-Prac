namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 29, 10, 14, 37, 14 };

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
