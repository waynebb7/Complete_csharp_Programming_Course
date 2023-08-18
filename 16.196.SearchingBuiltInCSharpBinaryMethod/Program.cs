using System.Diagnostics;

namespace _16._196.SearchingBuiltInCSharpBinaryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = new int[6] { 1, 3, 5, 6, 8, 11 };
            Debug.WriteLine(Array.BinarySearch(example, 6)); // Returns the index position of 6
        }
    }
}