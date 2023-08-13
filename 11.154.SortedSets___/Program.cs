using System.Collections.Generic;
using System.Diagnostics;

namespace _11._154.SortedSets___
{
    internal class Program
    {
        static SortedSet<int> sortedSet = new SortedSet<int>();
        static SortedSet<int> sortedSet2 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
        static SortedSet<int> list2 = new SortedSet<int>() { 6, 7, 8 };
        static SortedSet<int> list3 = new SortedSet<int>() { 4, 5, 6, 7, 8 };

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

            if (sortedSet.IsSubsetOf(new List<int> { 1, 2, 3 })) { }
            if (sortedSet.IsSupersetOf(new List<int> { 1, 2, 3 })) { }

            Debug.WriteLine(sortedSet.Overlaps(new List<int> { 1, 2, 3 }));

            sortedSet.Remove(4);

            sortedSet2.RemoveWhere(x => x > 2);

            foreach (int i in sortedSet2)
            {
                Debug.WriteLine(i);
            }

            foreach (int i in sortedSet2.Reverse())
            {
                Debug.WriteLine(i);
            }

            Debug.WriteLine("UnionWith():");
            sortedSet2.UnionWith(list2);

            foreach (int i in sortedSet2)
            {
                Debug.WriteLine(i);
            }

            Debug.WriteLine("ExceptWith():");
            sortedSet2.ExceptWith(list3);

            foreach (int i in sortedSet2)
            {
                Debug.WriteLine(i);
            }

            Debug.WriteLine("SymmetricExceptWith():");
            sortedSet2.SymmetricExceptWith(list3);

            foreach (int i in sortedSet2)
            {
                Debug.WriteLine(i);
            }

            Debug.WriteLine("IntersectWith():");
            sortedSet2.IntersectWith(list3);

            foreach (int i in sortedSet2)
            {
                Debug.WriteLine(i);
            }

            Debug.WriteLine("Count:");
            Debug.WriteLine(sortedSet.Count);
            Debug.WriteLine(sortedSet2.Count);
            Debug.WriteLine(list2.Count);
            Debug.WriteLine(list3.Count);

            Debug.WriteLine("Max:");
            Debug.WriteLine(sortedSet.Max);
            Debug.WriteLine(sortedSet2.Max);
            Debug.WriteLine(list2.Max);
            Debug.WriteLine(list3.Max);

            Debug.WriteLine("Min:");
            Debug.WriteLine(sortedSet.Min);
            Debug.WriteLine(sortedSet2.Min);
            Debug.WriteLine(list2.Min);
            Debug.WriteLine(list3.Min);


            sortedSet.Clear();

        }
    }
}