namespace _10._130.IEquatableInterface___
{
    public class Program : IEquatable<Program>
    {
        public string exampleData;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool Equals(Program? other)
        {
            if(other == null)
            {
                return false;
            }
            return exampleData.GetHashCode().Equals(other.exampleData.GetHashCode());
        }
    }
}