using System.Collections.Generic;
using System.Diagnostics;

namespace _1._150.Dictionary___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("key1", "value1");
            dictionary.Add("key2", "value2");
            dictionary.Add("key3", "value3");

            Debug.WriteLine(dictionary.Count);

            foreach (string s in dictionary.Keys)
            {
                Debug.WriteLine(s);
            }
            foreach (string s in dictionary.Values)
            {
                Debug.WriteLine(s);
            }

            Debug.WriteLine("\nRemoved \"key1\" ");
            dictionary.Remove("key1");

            foreach (string s in dictionary.Keys)
            {
                Debug.WriteLine(s);
            }
            foreach (string s in dictionary.Values)
            {
                Debug.WriteLine(s);
            }

            // Doing it correctly
            Debug.WriteLine("\nAdding a unique key correctly...see code.");
            ////////////////////////////////////////////////////////////////////
            // Correctly add a key. Always check it doesn't already exist.
            if (!dictionary.ContainsKey("key5"))
            {
                dictionary.Add("key5", "value5");
            }
            // Check
            foreach (string s in dictionary.Keys)
            {
                Debug.WriteLine(s);
            }

            Debug.WriteLine("\nRemoving a unique key correctly...see code.");
            ////////////////////////////////////////////////////////////////////
            // Correctly remove a key. Always check it doesn't already exist.
            if (dictionary.ContainsKey("key5"))
            {
                dictionary.Remove("key5");
            }
            // Check
            foreach (string s in dictionary.Keys)
            {
                Debug.WriteLine(s);
            }

            Debug.WriteLine("\nReturning a key correctly...see code.");
            ////////////////////////////////////////////////////////////////////
            // Correctly return a key. Always check it exists.
            if (dictionary.ContainsKey("key2"))
            {
                Debug.WriteLine(dictionary["key2"]);
            }

            Debug.WriteLine("\nBest method: TryGetValue. Returning a key correctly...see code.");
            ////////////////////////////////////////////////////////////////////
            // Using the TryGetValue method.
            string value = "";
            dictionary.TryGetValue("key1", out value);
            Debug.WriteLine(dictionary.TryGetValue("key2", out value));


        }
    }
}