using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _10._131.IEqualityComparer___
{
    public class Officer
    {
        Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
    }

    internal class Program : IEqualityComparer<Officer>
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool Equals([AllowNull]Officer? x, [AllowNull] Officer? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Officer obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}