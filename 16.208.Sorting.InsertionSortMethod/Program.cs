using System.Diagnostics;

namespace _16._208.Sorting.InsertionSortMethod
{
    internal class Program
    {
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i];
                int j = i - 1;
                while (j > -1 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = value;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] unsortedArray = { 12, 11, 13, 5, 6 };
            int[] sortedArray = InsertionSort(unsortedArray);

            foreach (int num in sortedArray)
            {
                Debug.Write(num + " ");
            }
        }
    }


    // THIS CODE IS DIRECTLY FROM THE COURSE BUT IS INCORRECT
    // The line arr[i + 1] = value; should be replaced with arr[j + 1] = value; to properly insert the value at the correct position in the sorted subarray.
    //internal class Program
    //{
    //    static int[] insertionSort(int[] arr)
    //    {
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            int value = arr[i];
    //            for (int j = i - 1; j > -1 && arr[j] > value; j--)
    //            {
    //                arr[j + 1] = arr[j];
    //            }
    //            arr[i + 1] = value;
    //        }
    //        return arr;
    //    }

    //    static void Main(string[] args)
    //    {
    //    }
    //}
}