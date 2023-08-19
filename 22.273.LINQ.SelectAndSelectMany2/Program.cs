using System.Diagnostics;

namespace _22._273.LINQ.SelectAndSelectMany2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> collection = new List<List<int>>()
            {
                new List<int>() { 1, 2, 3 },
                new List<int>() { 4,5,6 },
                new List<int>() { 7,8,9 }
            };

            IEnumerable<int> result = collection.SelectMany(list => list);
            Debug.WriteLine(result.Count().ToString());

            foreach (int i in result)
            {
                Debug.Write(i.ToString() + " ");
            }

            Debug.Write(string.Empty);
        }
    }
}