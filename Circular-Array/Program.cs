namespace Circular_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            CircularArray<int> array = new CircularArray<int>(5);
            array.Add(5);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(6);

            int[] available = array.PrintAvailable();

            foreach (int number in available)
            {
                System.Console.WriteLine(number);
            }

            array.Remove();
            array.Remove();
            array.Remove();
            array.Remove();

            available = array.PrintAvailable();

            foreach (int number in available)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}
