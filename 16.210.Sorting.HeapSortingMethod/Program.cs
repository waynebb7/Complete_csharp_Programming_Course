using System.Diagnostics;

namespace _16._210.Sorting.HeapSortingMethod
{
    internal class Program
    {
        public static int[] HeapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                Heapify(arr, i, 0);
            }

            return arr; // Return the sorted array THIS LINE WAS MISSING FROM COURSE CODE
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                Swap(arr, i, largest);
                Heapify(arr, n, largest);
            }
        }

        static void Swap(int[] arr, int element1, int element2)
        {
            int swap = arr[element1];
            arr[element1] = arr[element2];
            arr[element2] = swap;
        }

        static void Main(string[] args)
        {
            int[] unsortedArray = { 12, 11, 13, 5, 6, 7 };
            int[] sortedArray = HeapSort(unsortedArray);

            foreach (int num in sortedArray)
            {
                Debug.Write(num + " ");
            }
        }
    }


    // THIS CODE IS DIRECTLY FROM THE COURSE BUT IS INCORRECT (
    //internal class Program
    //{
    //    public static int[] HeapSort(int[] arr)
    //    {
    //        int n = arr.Length;
    //        for (int i = n / 2 - 1; i >= 0; i--)
    //        {
    //            heapify(arr, n, i);

    //        }

    //        for (int i = n - 1; i >= 0; i--)
    //        {
    //            swap(arr, 0, i);
    //            heapify(arr, i, 0);
    //        }
    //        return arr; // THIS WAS MISSING FROM COURSE CODE
    //    }

    //    static void heapify(int[] arr, int n, int i)
    //    {
    //        int largest = i;
    //        int left = 2 * i + 1;
    //        int right = 2 * i + 2;

    //        if (left < n && arr[left] > arr[largest])
    //        {
    //            largest = left;
    //        }
    //        if (right < n && arr[right] > arr[largest])
    //        {
    //            largest = right;
    //        }

    //        if (largest != i)
    //        {
    //            swap(arr, i, largest);
    //            heapify(arr, n, largest);
    //        }
    //    }

    //    static void swap(int[] arr, int element1, int element2)
    //    {
    //        int swap = arr[element1];
    //        arr[element1] = arr[element2];
    //        arr[element2] = swap;
    //    }
    //    static void Main(string[] args)
    //    {
    //        int[] unsortedArray = { 12, 11, 13, 5, 6, 7 };
    //        int[] sortedArray = HeapSort(unsortedArray);

    //        foreach (int num in sortedArray)
    //        {
    //            Debug.Write(num + " ");
    //        }
    //    }
    //}
}