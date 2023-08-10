// Constraints on Type Parameters
// where T : struct
// where T : class
// where T : not null
// where T : unmanaged
// where T : new()
// where T : <base class name>
// where T : <interface name>
// where T : U

// Generic Classes 
// Compare<T>
// EqualityComparer<T>
// HashSet<T>
// KayedByTypeCollection<TItem>
// LinkedList<T>
// LinkedListNode<T>
// List<T>
// Queue<T>
// SortedDictionary<TKey, TValue>
// SortedList<TKey, TValue>
// SortedSet<T>
// Stack<T>
// SychronisedCollection<T>
// SychronisedKeyCollection<K,T>
// SychronisedReadOnlyCollection<T>

// Generic Interfaces
// IList<T>
// IReadonlyCollection<T>
// IReadonlyDictionary<TKey, TValue>
// IReadonlyList<T>
// ISet<T>
// ICollection<T>
// IComparer<T>
// IDictionary<TKey, TValue>
// IEnumerable<T>
// IEnumerator<T>
// IEqualityComparer<T>


namespace _18._230.Generics
{
    class Example2
    {

    }

    interface IExample3
    {

    }


    internal class Example<T, U> where T : Example2, IExample3
                                 where U : Example2
    {
        static void Main(string[] args)
        {
            
        }
    }
}