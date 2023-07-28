namespace BinarySearch
{
    /// <summary>
    /// Basic binary search algorithm of an array
    /// </summary>
    public class BinarySearch
    {
        public bool Search(int[] arr, int numberToSearch)
        {
            double left = 0;
            double right = arr.Length - 1;
            int total;

            while (true)
            {
                total = (int)Math.Truncate((left + right) / 2);

                if (arr[total] < numberToSearch)
                {
                    left = total + 1;
                }
                else if (arr[total] > numberToSearch)
                {
                    right = total - 1;
                }
                else
                {
                    return true;
                }

            }
        }
    }
}