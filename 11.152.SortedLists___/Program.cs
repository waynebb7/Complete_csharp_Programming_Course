using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace _11._152.SortedLists___
{
    internal class Program
    {
        static SortedList<string, int> sortedList = new SortedList<string, int>() { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };

        static void Main(string[] args)
        {
            sortedList.Capacity = 10;
            Debug.WriteLine("The sortedList's capacity is: " + sortedList.Capacity);
            Debug.WriteLine("The sortedList's count is: " + sortedList.Count);

            foreach (string element in sortedList.Keys)
            {
                Debug.WriteLine(element);
            }

            foreach (int element in sortedList.Values)
            {
                Debug.WriteLine(element);
            }

            // Add to add a new key with data
            sortedList.Add("key4", 4);

            foreach (string element in sortedList.Keys)
            {
                Debug.WriteLine(element);
            }

            foreach (int element in sortedList.Values)
            {
                Debug.WriteLine(element);
            }

            // Remove to remove a particular key
            sortedList.Remove("key1");

            foreach (string element in sortedList.Keys)
            {
                Debug.WriteLine(element);
            }

            foreach (int element in sortedList.Values)
            {
                Debug.WriteLine(element);
            }

            // RemoveAt method to remove a particular index position
            sortedList.RemoveAt(0);

            foreach (string element in sortedList.Keys)
            {
                Debug.WriteLine(element);
            }

            foreach (int element in sortedList.Values)
            {
                Debug.WriteLine(element);
            }

            // Check sortedList contains key
            if (sortedList.ContainsKey("key1"))
            {
                Debug.WriteLine("YEP");
            }
            else
            {
                Debug.WriteLine("NOPE");
            }

            // Check sortedList contains value
            if (sortedList.ContainsValue(3))
            {
                Debug.WriteLine("YEP");
            }
            else
            {
                Debug.WriteLine("NOPE");
            }

            Debug.WriteLine("Index of key1: "+sortedList.IndexOfKey("key1"));
            Debug.WriteLine("Index of key2: "+sortedList.IndexOfKey("key2"));
            Debug.WriteLine("Index of key3: "+sortedList.IndexOfKey("key3"));
            Debug.WriteLine("Index of key4: "+sortedList.IndexOfKey("key4"));
            
            Debug.WriteLine("Index of key1: "+sortedList.IndexOfValue(1));
            Debug.WriteLine("Index of key2: "+sortedList.IndexOfValue(2));
            Debug.WriteLine("Index of key3: "+sortedList.IndexOfValue(3));
            Debug.WriteLine("Index of key4: "+sortedList.IndexOfValue(4));

            // Clear to empty the sortedList
            sortedList.Clear();

        }
    }
}