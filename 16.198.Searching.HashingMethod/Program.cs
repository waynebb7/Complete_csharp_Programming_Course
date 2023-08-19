using System.Diagnostics;

namespace _16._198.Searching.HashingMethod
{
    // This version by WBB provides the algorithm and an implementation
    internal class Program
    {
        static void SearchHashTable(Dictionary<int, string> hashTable, int keyToSearch)
        {
            if (hashTable.ContainsKey(keyToSearch))
            {
                string value = hashTable[keyToSearch];
                Debug.WriteLine($"Value for key {keyToSearch}: {value}");
            }
            else
            {
                Debug.WriteLine($"Key {keyToSearch} not found in the hash table.");
            }
        }

        static void Main(string[] args)
        {
            Dictionary<int, string> hashTable = new Dictionary<int, string>();

            // Adding elements to the hash table
            hashTable.Add(101, "Alice");
            hashTable.Add(102, "Bob");
            hashTable.Add(103, "Charlie");
            hashTable.Add(104, "David");
            hashTable.Add(105, "Eve");

            int keyToSearch = 103;

            SearchHashTable(hashTable, keyToSearch);
        }
    }

    // SIMPLE FORM
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dictionary<int, string> hashTable = new Dictionary<int, string>();

    //        // Adding elements to the hash table
    //        hashTable.Add(101, "Alice");
    //        hashTable.Add(102, "Bob");
    //        hashTable.Add(103, "Charlie");
    //        hashTable.Add(104, "David");
    //        hashTable.Add(105, "Eve");

    //        int keyToSearch = 103;

    //        if (hashTable.ContainsKey(keyToSearch))
    //        {
    //            string value = hashTable[keyToSearch];
    //            Debug.WriteLine($"Value for key {keyToSearch}: {value}");
    //        }
    //        else
    //        {
    //            Debug.WriteLine($"Key {keyToSearch} not found in the hash table.");
    //        }
    //    }
    //}
}
