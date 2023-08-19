using System.Collections;
using System.Diagnostics;

namespace _22._274.LINQ.OfTypeAndWhere2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>() { 1,2,3,4,5,6 };
            IEnumerable<int> collectionsOfInts = collection.Where(i => i > 3);
            foreach (int i in collectionsOfInts)
            {
                Debug.Write(i + " ");
            }
            Debug.WriteLine(string.Empty);
        }
    }
}