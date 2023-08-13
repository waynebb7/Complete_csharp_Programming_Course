using System.Collections.Generic;
using System.Diagnostics;

namespace _11._146.Stacks___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STACKS
            // Crete new Stack for strings called s
            Stack<string> s = new Stack<string>();
            // Add "a" and "b" to the Stack s
            s.Push("a");
            s.Push("b");

            // Return size of Stack using .Count() method and output to Output window
            Debug.WriteLine("The Stack s contains: "+s.Count() + " elements.");
        }
    }
} 