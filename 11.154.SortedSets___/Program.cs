using System.Collections.Generic;
using System.Diagnostics;

namespace _11._154.SortedSets___
{
    internal class Program
    {
        static SortedSet<int> sortedSet = new SortedSet<int>();

        static void Main(string[] args)
        {
            sortedSet.Add(4);
            sortedSet.Add(8);
            sortedSet.Add(1);
            sortedSet.Add(2);

            foreach (int i in sortedSet)
            {
                Debug.WriteLine(i);
            }

            if (sortedSet.Contains(1))
            {
                Debug.WriteLine("YEP");
            }
            else
            {
                Debug.WriteLine("NOPE");

            }
        }
    }
}