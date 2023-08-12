using System.Diagnostics;
using System.Xml.Linq;

namespace _11._144._2.Arrays
{
    internal class Program
    {
        // CREATE ARRAY
        // DECLARATION: static array of type int called myArray with no size declared
        // ASSIGNMENT: 3 variables to positions 0, 1 & 2
        static int[] myArray = { 1, 2, 3 };

        // CREATE ARRAY
        // DECLARATION: static array of type string called myArray with no size declared
        // ASSIGNMENT: 3 variables to positions "a", "b", "c"
        static string[] myStringArray = { "a", "b", "c" };

        static void Main(string[] args)
        {
            // Working with the int array
            // Use foreach loop to cycle through array myArray and write location contents to the output screen
            foreach (int element in myArray)
            {
                Debug.WriteLine(element);
            }

            // Write a specific index location to the output window
            Debug.WriteLine(myArray[0]);

            // Assign a value to a specific index location
            myArray[0] = 5;
            Debug.WriteLine(myArray[0]);

            // Find the length of an array
            Debug.WriteLine("Array myArray length is: " + myArray.Length);

            // Sort an array
            Array.Sort(myArray);

            // Check to see if the array is sorted by using a foreach loop to output the array elements to the output window
            foreach (int element in myArray)
            {
                Debug.WriteLine(element);
            }

            // Append
            Debug.WriteLine("Append 5");
            myArray.Append(5);
            foreach (int element in myArray)
            {
                Debug.WriteLine(element);
            }

            // Working with the string array
            foreach (string i in myStringArray)
            {
                Debug.WriteLine(i);
            }

            // To get a better understanding of arrays type System.Array and right click on Array and select Go To Definition
            // Arrays derive from the abstract array class
            // System.Array

        }
    }
}