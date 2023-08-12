using System.Collections.Generic;
using System.Diagnostics;

namespace _11._145.Lists___
{
    internal class Program
    {
        static List<int> numbers = new List<int>() { 1, 3, 5, 2, 4 };

        static List<int> subList = new List<int>() { 7, 8 };


        static void Main(string[] args)
        {
            // Count returns the number of elements in the list
            Debug.WriteLine("Number of elements in list: " + numbers.Count);

            // Capacity sets the maximum size of the list
            numbers.Capacity = 10;

            // Add adds an element to the end of the list
            numbers.Add(6);
            Debug.WriteLine(numbers.Count);

            // Write each element in the list to the output window
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }

            // AddRange adds another list
            Debug.WriteLine("AddRange use here to add elements 7 & 8 from subList");
            numbers.AddRange(subList);
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }


            // Binary Search method returns the index of the element it is looking for
            // If element is not found it returns a negative number
            // Pre-requisit is that the list must be sorted first
            Debug.WriteLine("BinarySearch method:");
            // Sort (first sort the list)
            numbers.Sort();
            Debug.WriteLine("Index of element 5 is : " + numbers.BinarySearch(5));




        }
    }
}