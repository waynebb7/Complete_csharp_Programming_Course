using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 7 };

        // Sorting in descending order using Array.Sort() and Comparison<T> delegate
        Array.Sort(numbers, (x, y) => y.CompareTo(x));

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


        //ascending
        Array.Sort(numbers); // Sort the array in ascending order

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //reverse the array
        Array.Reverse(numbers);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
