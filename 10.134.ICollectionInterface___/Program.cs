using System.Collections;


namespace _10._134.ICollectionInterface___
{
    internal class Program : ICollection
    {
        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}