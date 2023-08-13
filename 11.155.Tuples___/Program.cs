using System.Diagnostics;

namespace _11._155.Tuples___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int> tuple = Tuple.Create(1);
            Tuple<int, int> tuple2 = Tuple.Create(1, 2);
            Tuple<int, int, int> tuple3 = Tuple.Create(1, 2, 3);
            Tuple<int, int, int, int> tuple4 = Tuple.Create(1, 2, 3, 4);
            Tuple<int, int, int, int, int> tuple5 = Tuple.Create(1, 2, 3, 4, 5);
            Tuple<int, int, int, int, int, int> tuple6 = Tuple.Create(1, 2, 3, 4, 5, 6);
            Tuple<int, int, int, int, int, int, int> tuple7 = Tuple.Create(1, 2, 3, 4, 5, 6, 7);

            Tuple<int, string, bool> mixedTypeTuple = Tuple.Create(1, "hello world", true);


            Tuple<int, int, int> tuple8 = Tuple.Create(1, 2, 3);
            Debug.WriteLine("Value of item 1 = " + tuple8.Item1);
            Debug.WriteLine("Value of item 2 = " + tuple8.Item2);
            Debug.WriteLine("Value of item 3 = " + tuple8.Item3);


        }
    }
}