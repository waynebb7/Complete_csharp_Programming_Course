using System.Diagnostics;

namespace _11._153.SortedDictionary___
{
    internal class Program
    {
        static SortedDictionary<string,string> sortedDictionary = new SortedDictionary<string, string>()
        {
            { "key1", "value1" },
            { "key2", "value2" },
            { "key3", "value3" }
        };
        static void Main(string[] args)
        {
            sortedDictionary.Add("key4", "value4");

            Debug.WriteLine(sortedDictionary.Comparer.ToString());

            if (sortedDictionary.ContainsKey("key1"))
            {
                Debug.WriteLine("Yes it contains the key");
            }
            else
            {
                Debug.WriteLine("NOPE"); 
            }

            // Best practice
            string value = string.Empty;
            sortedDictionary.TryGetValue("key1", out value);
            Debug.WriteLine(value);

            // Remove
            sortedDictionary.Remove("key2");

            sortedDictionary.Clear();
        }
    }
}