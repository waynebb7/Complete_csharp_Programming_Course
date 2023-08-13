// Important note: This code is not completed. See course notes to complete.

// Coder:           Wayne Barrass-Brown
// Date Created:    13 Aug 2023
// Date Reviewed:   13 Aug 2023



using System.Collections.Generic;
using System.Diagnostics;

namespace _11._156._1.LinkedList___
{
    internal class Program
    {
        static LinkedList<string> linkedList = new LinkedList<string>();

        static void Main(string[] args)
        {
            // AddAfter, AddBefore, AddFirst, AddLast
            linkedList.AddFirst("root");
            linkedList.AddAfter(linkedList.First, "element");
            linkedList.AddBefore(linkedList.First, "new root");
            linkedList.AddLast("Last Element");

            Debug.WriteLine(linkedList.Count);
            Debug.WriteLine(linkedList.First.Value);
            Debug.WriteLine(linkedList.Last.Value);

            if(linkedList.Contains("last element")) { }

            LinkedListNode<string> node = linkedList.Find("root");
            Debug.WriteLine(node.Value);

            LinkedListNode<string> node2 = linkedList.FindLast("root");
            Debug.WriteLine(node.Value);


            //remove the node, remove the value, remove first, remove last
            linkedList.Remove(node);
        }
    }
}