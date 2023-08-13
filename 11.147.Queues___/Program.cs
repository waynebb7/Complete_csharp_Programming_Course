using System.Collections.Generic;
using System.Diagnostics;

namespace _11._147.Queues___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();  

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            Debug.WriteLine(queue.Dequeue());
            Debug.WriteLine(queue.Peek());
            Debug.WriteLine(queue.Peek());
        }
    }
}