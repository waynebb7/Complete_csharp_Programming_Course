using System.Diagnostics;

namespace _21._262.Locking
{
    internal class Program
    {
        static string name = "";

        static void Example1()
        {
            Debug.WriteLine("Example 1");
            lock (name)
            {
                name = "Rob";
            }
        }

        static void Example2()
        {
            Debug.WriteLine("Example 2");
            lock (name)
            {
                name = "Jessica";
            }
        }

        static void Example3()
        {
            Debug.WriteLine("Example 3");
            lock (name)
            {
                name = "John";
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Example1);
            Thread t2 = new Thread(Example2);
            Thread t3 = new Thread(Example3);

            t1.Start();
            t2.Start();
            t3.Start();

            Thread.Sleep(3000);

            Debug.WriteLine(name);

        }
    }
}