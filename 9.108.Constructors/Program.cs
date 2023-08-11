using System.Diagnostics;

namespace _9._108.Constructors
{
    internal class Program
    {
        int exampleNumber;
        string exampleName;

        // Constructor: used to initialize variable int exampleNumber with whatever is passed in from Main()
        public Program(int num)
        {
            exampleNumber = num;
        }

        // An overloaded Constructor
        public Program(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }

        static void Main(string[] args)
        {
            Program ex = new Program(5);
            Program ex2 = new Program(5, "Wayne");
            Debug.WriteLine(ex.exampleNumber);
            Debug.WriteLine(ex2.exampleNumber, ex2.exampleName);
        
        }
    }
}