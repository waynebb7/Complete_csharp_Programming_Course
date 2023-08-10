using System.Diagnostics;
using System.Threading;

namespace _21._261.ThreadPooling
{
    internal class Program
    {
        static void Example1(Object stateInfo)
        {
            Debug.WriteLine("Example 1");
        }

        static void Example2(Object stateInfo)
        {
            Debug.WriteLine("Example 2");
        }

        static void Example3(Object stateInfo)
        {
            Debug.WriteLine("Example 3");
        }



        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Example1);
            ThreadPool.QueueUserWorkItem(Example2);
            ThreadPool.QueueUserWorkItem(Example3);

            Debug.WriteLine("Thread count: " + ThreadPool.ThreadCount);

            Thread.Sleep(3000);
        }
    }
}