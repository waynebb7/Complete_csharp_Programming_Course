// Simplified Real World Example from Chat GPT


// We create an array named studentNames to store the names of students. The array can hold up to 5 strings.

// We populate the array by assigning values to its elements using index notation (studentNames[index] = value).

// We use a foreach loop to iterate through each element of the array and print out the student names.

// This example demonstrates how arrays can be used to store and manipulate collections of data in a structured way.
// In real-world scenarios, arrays are commonly used for tasks like storing data records, iterating through items,
// and performing various operations on collections of items.


using System;
using System.Diagnostics;

namespace _11._144._1.Arrays_RealWorldExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an array to store student names
            string[] studentNames = new string[5];

            // Populating the array with student names
            studentNames[0] = "Alice";
            studentNames[1] = "Bob";
            studentNames[2] = "Carol";
            studentNames[3] = "David";
            studentNames[4] = "Eve";

            // Displaying the student names
            Debug.WriteLine("Student Names:");
            foreach (string name in studentNames)
            {
                Debug.WriteLine(name);
            }
        }
    }
}