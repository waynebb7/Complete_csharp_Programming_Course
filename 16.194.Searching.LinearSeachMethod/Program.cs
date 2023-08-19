namespace _16._194.Searching.LinearSeachMethod
{
    // This version by WBB provides the algorithm and an implementation
    using System.Collections.Generic;
    using System.Diagnostics;

    internal class Program
    {
        static int LinearSearch(List<int> elements, int x)
        {
            int length = elements.Count;
            for (int i = 0; i < length; i++)
            {
                if (elements[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            List<int> elements = new List<int> { 10, 20, 30, 40, 50 };
            int target = 30;

            int result = LinearSearch(elements, target);

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

    //    static int linearSearch(List<int> elements, int x)
    //    {
    //        int length = elements.Count;
    //        for (int i = 0; i < length; i++)
    //        {
    //            if (elements[i] == x)
    //            {
    //                return i;
    //            }
    //        }
    //        return -1;
    //    }

    //    static void Main(string[] args)
    //    {

    //    }
    //}
}