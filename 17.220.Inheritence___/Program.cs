using System.Diagnostics;

namespace _17._220.Inheritence___
{
    internal class Program
    {

    }

    public class Class1
    {
        protected int myInt;

        protected void Print()
        {
            Debug.WriteLine("Hello World");
        }
    }

    public class Class2 : Class1
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Print();

            int myInt = obj.myInt;
        }
    }
}