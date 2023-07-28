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

            array.PrintArr();

            array.Remove();
            array.Remove();
            array.Remove();
            array.Remove();

            array.PrintArr();
        }
    }
}
