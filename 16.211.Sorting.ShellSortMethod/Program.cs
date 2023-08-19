using System.Diagnostics;

namespace _16._211.Sorting.ShellSortMethod
{
    // This version by WBB provides the algorithm and an implementation
    internal class Program
    {
        static int[] ShellSort(int[] arr)
        {
            int length = arr.Length;
            for (int gap = length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < length; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] unsortedArray = { 12, 34, 54, 2, 3 };
            int[] sortedArray = ShellSort(unsortedArray);

            foreach (int num in sortedArray)
            {
                Debug.Write(num + " ");
            }
        }
    }

    // THIS IS THE CODE DIRECTLY FROM THE COURSE BUT THERE IS AN ERROR
    //internal class Program
    //{
    //    int[] shellSort(int[] arr)
    //    {
    //        int length = arr.Length;
    //        for (int gap = length / 2; gap > 0; gap /= 2)
    //        {
    //            for (int i = gap; i < length; i += 1)
    //            {
    //                int temp = arr[i];
    //                int j;
    //                for (j = 1; j >= gap && arr[j - gap] > temp; j -= gap)
    //                {
    //                    arr[j] = arr[j - gap];
    //                }
    //                arr[j] = temp;
    //            }
    //        }
    //        return arr;
    //    }

    //    static void Main(string[] args)
    //    {
    //    }
    //}
}