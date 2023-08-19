using System.Diagnostics;

namespace _16._206.Sorting.QuickSortMethod
{
    // This version by WBB provides the algorithm and an implementation
    internal class Program
    {
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right])
                    {
                        right--;
                    }
                    else
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                }
                else
                {
                    return right;
                }
            }
        }

        static int[] quickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            int[] sortedArray = quickSort(unsortedArray, 0, unsortedArray.Length - 1);

            Debug.WriteLine("Sorted array:");
            foreach (int num in sortedArray)
            {
                Debug.Write(num + " ");
            }
        }


        // THIS CODE IS FROM THE COURSE BUT HAS ERRORS
        //internal class Program
        //{
        //    static int Partition(int[] arr, int left, int right)
        //    {
        //        int pivot = arr[left];
        //        while (true)
        //        {
        //            while (arr[left] < pivot)
        //            {
        //                left++;
        //            }

        //            while (arr[right] > pivot)
        //            {
        //                right--;
        //            }

        //            if (left < right)
        //            {
        //                if (arr[left] == arr[right])
        //                {
        //                    return right;
        //                }
        //            }
        //        }

        //        static int[] quickSort(int[] arr, int left, int right)
        //        {
        //            if (left < right)
        //            {
        //                int pivot = Partition(arr, left, right);
        //                if (pivot > 1)
        //                {
        //                    quickSort(arr, left, pivot - 1);
        //                }
        //                if (pivot + 1 < right)
        //                {
        //                    quickSort(arr, pivot + 1, right);
        //                }
        //            }
        //            return arr;
        //        }
        //    }

        //    static void Main(string[] args)
        //    {
        //    }
        //}
    }
}