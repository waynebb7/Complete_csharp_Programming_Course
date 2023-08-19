using System.Diagnostics;

namespace _22._272.LINQCast
{
    internal class Program
    {
        // This version by WBB provides is correct
        static void Main(string[] args)
        {
            List<int> collection = new List<int>() { 1, 2, 3 };
            IEnumerable<float> collectionOfFloats = collection.Select(item => (float)item);

            foreach (float num in collectionOfFloats)
            {
                Debug.WriteLine(num);
            }
        }
    }
}

// THIS CODE IS DIRECTLY FROM THE COURSE BUT HAS AN ERROR
//namespace _22._272.LINQCast
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> collection = new List<int>() { 1, 2, 3 };
//            IEnumerable<float> collectionOfFloats = new collection.Cast<float>();
//        }
//    }
//}