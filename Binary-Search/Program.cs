namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedNumbers = { 2, 5, 8, 15, 54, 55, 67 };

            BinarySearch sorted = new BinarySearch();
            bool exist = sorted.Search(sortedNumbers, 776853376);

            System.Console.WriteLine(exist);

        }
    }
}