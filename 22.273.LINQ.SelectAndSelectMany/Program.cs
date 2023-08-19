using System.Diagnostics;
using System.Linq;

namespace _22._273.LINQ.SelectAndSelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>() { 1,2,3 };
            IEnumerable<int> collectionOfIntsMultipliedBy2 = collection.Select(s => s * 2);
            foreach(int i in collectionOfIntsMultipliedBy2)
            {
                Debug.Write(i.ToString() + " ");
            }
            Debug.Write(string.Empty);
        }
    }
}