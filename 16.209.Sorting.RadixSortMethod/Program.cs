using System.Diagnostics;
using System;

// THIS VERSION WORKS (Got this from w3resource.com)
namespace Radix_Sort
{
    class Program
    {
        static void Sort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }
        static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Debug.WriteLine("\nOriginal array : ");
            foreach (var item in arr)
            {
                Debug.Write(" " + item);
            }

            Sort(arr);
            Debug.WriteLine("\nSorted array : ");
            foreach (var item in arr)
            {
                Debug.Write(" " + item);
            }
            Debug.WriteLine("\n");
        }
    }
}


// THIS IS A CORRECTED VERSION BY WBB BUT STILL HAS AN ISSUE (Prints out 66 8 times)
//namespace _16._209.Sorting.RadixSortMethod
//{
//    internal class Program
//    {
//        static int[] RadixSort(int[] data)
//        {
//            int[] temp = new int[data.Length];

//            for (int shift = 31; shift > -1; shift--)
//            {
//                int j = 0;

//                for (int i = 0; i < data.Length; i++)
//                {
//                    bool move = (data[i] << shift) >= 0;

//                    if (shift == 0 ? !move : move)
//                    {
//                        data[i - j] = data[i];
//                    }
//                    else
//                    {
//                        temp[j] = data[i];
//                        j++;
//                    }
//                }
//                Array.Copy(temp, 0, data, 0, j);
//            }
//            return data;
//        }

//        static void Main(string[] args)
//        {
//            int[] unsortedArray = { 170, 45, 75, -90, -802, 24, 2, 66 };
//            int[] sortedArray = RadixSort(unsortedArray);

//            foreach (int num in sortedArray)
//            {
//                Debug.Write(num + " ");
//            }
//        }
//    }
//}


// THIS CODE IS DIRECTLY FROM THE COURSE BUT IS INCORRECT (IT DOESN@T SORT)

//    internal class Program
//    {
//        static int[] RadixSort(int[] data)
//        {
//            int[] temp = new int[data.Length];

//            for (int shift = 31; shift > -1; shift--)
//            {
//                int j = 0;

//                for (int i = 0; i < data.Length; i++)
//                {
//                    bool move = (data[i] << shift) >= 0;

//                    if (shift == 0 ? !move : move)
//                    {
//                        data[i - j] = data[i];
//                    }
//                    else
//                    {
//                        temp[j] = data[i];
//                    }
//                }
//                Array.Copy(temp, 0, data, data.Length - j, j);
//            }
//            return data;
//        }

//        static void Main(string[] args)
//        {
//            int[] unsortedArray = { 170, 45, 75, -90, -802, 24, 2, 66 };
//            int[] sortedArray = RadixSort(unsortedArray);

//            foreach (int num in sortedArray)
//            {
//                Debug.Write(num + " ");
//            }
//        }
//    }
//}
