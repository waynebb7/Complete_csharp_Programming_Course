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


using System.Diagnostics;

namespace _18._232.Generics
{

    public class Example<T>
    {
        public static void PrintMessage<T>(T message)
        {
            Debug.WriteLine(message.ToString());
        }

        public static void PrintMessage<T>(T message, T prefix)
        {
            Debug.WriteLine(prefix.ToString() + message.ToString());
        }

        public static void PrintMessage<T>(T message, T prefix, T suffix)
        {
            Debug.WriteLine(prefix.ToString() + message.ToString() + suffix.ToString());
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example<string>.PrintMessage("Hi");
            Example<int>.PrintMessage(2);
            Example<bool>.PrintMessage(true);
        }
    }
}