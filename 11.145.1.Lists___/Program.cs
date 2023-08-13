using System.Diagnostics;

namespace _11._145._1.Lists___
{
    internal class Program
    {
        static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2, 3, 4, 3 };

        /// <summary>
        /// Prints input i to output window.
        /// </summary>
        /// <param name="i"></param>
        static void PrintToOutputWindow(int i)
        {
            Debug.WriteLine(i);
        }



        static void Main(string[] args)
        {
            PrintToOutputWindow(5);
            // Runs PrintToOutputWindow on each element in List numbers
            numbers.ForEach(PrintToOutputWindow);

            // IndexOf(3)
            Debug.WriteLine("Using IndexOf(3) method:");
            Debug.WriteLine(numbers.IndexOf(3));

            // LastIndexOf(3)
            Debug.WriteLine("Using LastIndexOf(3) method:");
            Debug.WriteLine(numbers.LastIndexOf(3));

            // FindLast
            Debug.WriteLine("Using FindLast method to find last method in the list less than 3:");
            // Thi returns the actual number not the index. Don't get confused.
            Debug.WriteLine(numbers.FindLast( x  => x < 3));

            int[] arrayOfNumbers = numbers.ToArray(); // This is the old fashioned way of doing things. Try not to use this. Use lists.


        }
    }
}