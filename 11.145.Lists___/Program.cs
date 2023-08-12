using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;

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


            Debug.WriteLine("Contains (6) method: ");
            // Check a list to see if it contains an element
            numbers.Contains(6);
            Debug.WriteLine(numbers.Contains(6));

            Debug.WriteLine("Contains (20) method: ");
            // Check a list to see if it contains an element
            numbers.Contains(20);
            Debug.WriteLine(numbers.Contains(20));

            // Empty a list of all of its elements
            //numbers.Clear();

            // Insert
            Debug.WriteLine("\nUsing Insert(0,9) method to insert int 9 in position 0: ");
            numbers.Insert(0, 9);
            Debug.WriteLine("Check list to see if (9) exists and output result: ");
            // Check a list to see if it contains an element
            Debug.WriteLine(numbers.Contains(9));
            Debug.WriteLine("\nWrite all elements of list to output window as a check: ");
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }
            // Sort list
            numbers.Sort();
            Debug.WriteLine("\nAfter sort method write all elements of list to output window as a check: ");
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }


            // INSERT using InsertRange(1, myNewSubList) method
            // Create new sublist | Insert sublist myNewSubList into numbers list at index position 1
            List<int> myNewSubList = new List<int>() { 638, 249 };
            numbers.InsertRange(1, myNewSubList);
            Debug.WriteLine("\nAfter Insertrange() method write all elements of list to output window as a check: ");
            // Output list elements to output window
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }

            // REMOVE using Remove(2) method. Note that this removes the element holding the actual value int 2.
            // If there are more than one occurence of the number 2 in the list it will only remove the first occurence.
            Debug.WriteLine("\nAfter Remove(2) method write all elements of list to output window as a check: ");
            numbers.Remove(2);
            // Output list elements to output window
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }

            // REMOVE using RemoveAt(1) method. Note that this removes the element at position 1 and whatever is held in that position.
            Debug.WriteLine("\nAfter RemoveAt(1) method write all elements of list to output window as a check: ");
            numbers.RemoveAt(1);
            // Output list elements to output window
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }

            // REMOVE using RemoveRange(1,4) method. Note that this removes all elements from index position 1 for the range given. In this case 4.
            Debug.WriteLine("\nAfter RemoveRange(1,4) method write all elements of list to output window as a check: ");
            numbers.RemoveRange(1, 4);
            // Output list elements to output window
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }

            // CAPACITY & TRIM
            // Set capacity size to 10
            numbers.Capacity = 10;
            // Get capacity and output result to output window
            Debug.WriteLine("Capacity before trim: " + numbers.Capacity);
            // TrimExcess. Note actual list holds 5 elements right now but has a capacity to hold 10.
            // By trimming the excess it shrinks the list size down to the exact size required.
            numbers.TrimExcess();
            Debug.WriteLine("Capacity after trim: " + numbers.Capacity);


            // TrueForAll method for checking a condition on the complete list.
            // Create bool variable to hold the true/false result.
            bool areNumbersLessThan6 = numbers.TrueForAll(x => x < 6);
            // Output the result to the output window
            Debug.WriteLine("\nAre all numbers in the list less than 6: " + areNumbersLessThan6);
            //Debug.WriteLine("\nAre all numbers in the list less than 6: " + ((bool(numbers.TrueForAll(x => x < 6))); // problem casting this to a bool needs a review

            // Create bool variable to hold the true/false result.
            bool areNumbersMoreThan6 = numbers.TrueForAll(x => x > 6);
            // Output the result to the output window
            Debug.WriteLine("\nAre all numbers in the list less than 6: " + areNumbersMoreThan6);

            bool areNumbersLessThan1000 = numbers.TrueForAll(x => x < 1000);
            // Output the result to the output window
            Debug.WriteLine("\nAre all numbers in the list less than 1000: " + areNumbersLessThan1000);

            // REVERSE using Reverse() method. 
            Debug.WriteLine("\nAfter Reverse() method write all elements of list to output window as a check: ");
            numbers.Reverse();
            // Output list elements to output window
            foreach (int i in numbers)
            {
                Debug.WriteLine(i);
            }

        }
    }
}