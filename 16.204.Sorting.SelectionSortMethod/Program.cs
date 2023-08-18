using System.Diagnostics;

namespace _16._204.Sorting.SelectionSortMethod
{
    class Program
    {
        static int[] SelectionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            return arr;
        }

        static void Main(string[] args)
        {
            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            int[] sortedArray = SelectionSort(unsortedArray);

            foreach (int num in sortedArray)
            {
                Debug.WriteLine(num + " ");
            }
        }
    }
}