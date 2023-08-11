namespace _9._116.InfiniteParametersforaFunction
{
    internal class Program
    {
        public static void Example1(params string[] words)
        {
            foreach (string word in words)
            {
                System.Diagnostics.Debug.WriteLine(word);
            }
        }

        public static void Main(string[] args)
        {
            Example1();
            Example1("Hi");
            Example1("Hi", "Hello World");
            Example1("Hi", "Hello World", "Goodbye");
        }
    }
}