using System.Diagnostics;

namespace _16._197.Searching.InterpolationSearch__
{
    // This version by WBB provides the algorithm and an implementation
    internal class Program
    {
        static int interpolationSearch(int[] arr, int length, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high && x >= arr[low] && x <= arr[high])
            {
                if (low == high)
                {
                    if (arr[low] == x)
                    {
                        return low;
                    }
                    else
                    {
                        return -1;
                    }
                }

                int pos = low + (high - low) / (arr[high] - arr[low]) * (x - arr[low]);

                if (arr[pos] == x)
                {
                    return pos;
                }
                if (arr[pos] < x)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] example = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 23, 34, 45, 56, 67, 78, 89 };
            Debug.Write("Array to be searched: ");
            foreach (int value in example)
            {
                Debug.Write(value.ToString() + " ");
            }
            Debug.WriteLine("\nIndex position of 12 is " + interpolationSearch(example, 17, 12));
            Debug.WriteLine("Index position of 3 is " + interpolationSearch(example, example.Length, 3));
            Debug.WriteLine("Index position of 78 is " + interpolationSearch(example, example.Count(), 78));
        }
    }
}