using System.Diagnostics;

namespace _16._203.Sorting.BuiltInCSharpSortingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = new int[6] { 3, 1, 6, 2, 8, 0 };
            Array.Sort(example);
            foreach (int i in example)
            {
                Debug.Write(i + " ");
            }
            Debug.WriteLine("");
        }
    }
}