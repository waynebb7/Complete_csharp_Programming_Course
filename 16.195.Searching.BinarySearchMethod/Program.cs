namespace _16._195.Searching.BinarySearchMethod
{
    // This version by WBB provides the algorithm and an implementation
    using System.Collections.Generic;
    using System.Diagnostics;

    internal class Program
    {
        static int BinarySearch(List<int> elements, int x)
        {
            int start = 0;
            int stop = elements.Count - 1;
            int middle = (start + stop) / 2;

            while (elements[middle] != x && start <= stop)
            {
                if (x < elements[middle])
                {
                    stop = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }

                middle = (start + stop) / 2;
            }

            return (elements[middle] != x) ? -1 : middle;
        }

        static void Main(string[] args)
        {
            List<int> sortedElements = new List<int> { 10, 20, 30, 40, 50 };
            int target = 30;

            int result = BinarySearch(sortedElements, target);

            if (result != -1)
            {
                Debug.WriteLine($"Element {target} found at index {result}");
            }
            else
            {
                Debug.WriteLine($"Element {target} not found in the list");
            }
        }
    }


    // THIS CODE IS DIRECTLY FROM THE COURSE
    //internal class Program
    //{
    //    static int binarySearch(List<int> elements, int x)
    //    {
    //        int start = 0;
    //        int stop = elements.Count - 1;
    //        int middle = (int)((start + stop) / 2);
    //        while (elements[middle] != x && start < stop)
    //        {
    //            if (x < elements[middle])
    //            {
    //                stop = middle - 1;
    //            }
    //            else
    //            {
    //                start = middle + 1;
    //            }

    //            middle = (int)((start + stop) / 2);
    //        }

    //        return (elements[middle] != x) ? -1 : middle;
    //    }

    //    static void Main(string[] args)
    //    {

    //    }
    //}
}