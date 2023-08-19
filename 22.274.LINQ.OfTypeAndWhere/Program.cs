using System.Collections;
using System.Diagnostics;

namespace _22._274.LINQ.OfTypeAndWhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList collection = new ArrayList() { "a", 2, "b", 4, "c", 6 };
            IEnumerable<string> collectionsOfStrings = collection.OfType<string>();
            foreach (string str in collectionsOfStrings)
            {
                Debug.Write(str + " ");
            }
            Debug.WriteLine(string.Empty);
        }
    }
}