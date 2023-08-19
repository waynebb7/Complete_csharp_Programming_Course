using System.Diagnostics;

namespace _16._196.SearchingBuiltInCSharpBinaryMethod
{

    // This version by WBB provides the algorithm and an implementation
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = new int[6] { 1, 3, 5, 6, 8, 11 };
            int target = 6;

            int index = Array.BinarySearch(example, target);

            if (index >= 0)
            {
                Debug.WriteLine($"Element {target} found at index {index}");
            }
            else
            {
                // If the element is not found, adjust the index to the insert position
                // by taking the bitwise complement of the negative index
                int insertPosition = ~index;
                Debug.WriteLine($"Element {target} not found. Insert at index {insertPosition}");
            }
        }
    }


    // THIS CODE IS DIRECTLY FROM THE COURSE AND DOES NOT ACCOUNT FOR VALUE NOT BEING FOUND
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] example = new int[6] { 1, 3, 5, 6, 8, 11 };
    //        Debug.WriteLine(Array.BinarySearch(example, 6)); // Returns the index position of 6
    //    }
    //}
}