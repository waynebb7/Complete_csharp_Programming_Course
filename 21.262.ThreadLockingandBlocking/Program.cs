using System.Diagnostics;
using System.Threading;

namespace _21._262.ThreadLockingandBlocking
{
    internal class Program
    {
        static void Example1()
        {
            Debug.WriteLine("1");
            Debug.WriteLine("2");
            Debug.WriteLine("3");
            Debug.WriteLine("4");
            Debug.WriteLine("5");
        }

        static void Example2()
        {
            Debug.WriteLine("6");
            Debug.WriteLine("7");
            Debug.WriteLine("8");
            Debug.WriteLine("9");
            Debug.WriteLine("10");
        }



        static void Main(string[] args)
        {
            Thread t1 = new Thread(Example1);
            Thread t2 = new Thread(Example2);

            //// Starting the Threads one after the other will not give you control of order of execution
            //t1.Start();
            //t2.Start();

            // To control order of execution add the join() method
            t1.Start();
            t1.Join();
            t2.Start();

            // Sleep method
            Debug.WriteLine(DateTime.Now.ToString());
            Thread.Sleep(1000);
            Debug.WriteLine(DateTime.Now.ToString());
            Thread.Sleep(2000);
            Debug.WriteLine(DateTime.Now.ToString());
            Thread.Sleep(3000);
            Debug.WriteLine(DateTime.Now.ToString());


        }
    }
}