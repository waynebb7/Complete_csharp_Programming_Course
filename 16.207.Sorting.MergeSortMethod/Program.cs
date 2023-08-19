using System.Diagnostics;

namespace _16._207.Sorting.MergeSortMethod
{

    // THIS CODE HAS BEEN CORRECTED BY WBB
    internal class Program
    {
        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            if (array.Length <= 1)
            {
                return array;
            }

            int midPoint = array.Length / 2;

            left = new int[midPoint];

            if (array.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
            {
                left[i] = array[i];
            }

            int x = 0;

            for (int i = midPoint; i < array.Length; i++)
            {
                right[x++] = array[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);
            return result;
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0;
            int indexRight = 0;
            int indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                }
                indexResult++;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            int[] unsortedArray = { 12, 11, 13, 5, 6, 7 };
            int[] sortedArray = MergeSort(unsortedArray);

            foreach (int num in sortedArray)
            {
                Debug.Write(num + " ");
            }
        }
    }
}


// THIS IS THE ORIGINAL CODE FROM THR COURSE BUT IT IS INCORRECT
//internal class Program
//{
//    public static int[] mergeSort(int[] array)
//    {
//        int[] left;
//        int[] right;
//        int[] result = new int[array.Length];

//        if (array.Length <= 1)
//        {
//            return array;
//        }

//        int midPoint = array.Length / 2;

//        left = new int[midPoint];

//        if (array.Length % 2 == 0)
//        {
//            right = new int[midPoint];
//        }
//        else
//        {
//            right = new int[midPoint + 1];
//        }

//        for (int i = 0; i < midPoint; i++)
//        {
//            left[i] = array[i];
//        }

//        int x = 0;

//        for (int i = midPoint; i < array.Length; i++)
//        {
//            right[x++] = array[i];
//            x++;
//        }

//        left = mergeSort(left);
//        right = mergeSort(right);
//        result = merge(left, right);
//        return result;
//    }

//    public static int[] merge(int[] left, int[] right)
//    {
//        int resultLength = right.Length + left.Length;
//        int[] result = new int[resultLength];
//        int indexLeft = 0;
//        int indexRight = 0;
//        int indexResult = 0;

//        while (indexLeft < left.Length || indexRight < right.Length)
//        {
//            if (indexLeft < left.Length && indexRight < right.Length)
//            {
//                if (left[indexLeft] <= right[indexRight])
//                {
//                    result[indexLeft] = left[indexLeft];
//                    indexLeft++;
//                    indexResult++;
//                }
//                else
//                {
//                    result[indexResult] = right[indexRight];
//                    indexRight++;
//                    indexResult++;
//                }
//            }
//            else if(indexLeft < left.Length)
//            {
//                result[indexResult] = left[indexLeft];
//                indexLeft++;
//                indexResult++;
//            }
//            else if (indexLeft < right.Length)
//            {
//                result[indexResult] = right[indexRight];
//                indexRight++;
//                indexResult++;
//            }
//        }
//        return result;
//    }


