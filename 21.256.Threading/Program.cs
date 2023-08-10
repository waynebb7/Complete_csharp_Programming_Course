using System.Threading;

namespace _21._256.Threading
{
    internal class Program
    {
        static void ExampleFunction()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Diagnostics.Debug.WriteLine("Hello World");
            }
        }

        static void Main(string[] args)
        {
            //Thread t = new Thread(ExampleFunction);
            //t.Start();

            new Thread(ExampleFunction).Start();

            // Passing data into a Thread using a Lambda Expression
            Thread t = new Thread(() => { System.Diagnostics.Debug.WriteLine("Hello World2222222222222222222222"); });

            // Or pass an argument into the Threads start method | This does not work for this case.
            //new Thread(ExampleFunction).Start("Hello World 3");

            // Assign a name to a Thread
            Thread t1 = new Thread(ExampleFunction);
            t1.Name = "Thread 1";

            // Setting a Thread to be a background Thread
            Thread t2 = new Thread(ExampleFunction);
            t2.IsBackground = true;     // Specifies a background Thread
            t2.IsBackground = false;    // specifies a foreground Thread

            // Assigning Thread Priority (Lowest | Below Normal | Normal | Above Normal | Highest)
            Thread t3 = new Thread(ExampleFunction);
            t3.Priority = ThreadPriority.Normal;                       
        }
    }
} 