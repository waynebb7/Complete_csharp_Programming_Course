namespace _11._144.Arrays___
{
    internal class Program
    {
        // There are four (4) ways to create an array.
        string[] strings = new string[3];
        string[] strings2 = new string[3] { "a", "b", "c" };
        string[] strings3 = new string[] { "a", "b", "c" };
        string[] strings4 = { "a", "b", "c" };                  // The new keyword will need to be used when declaring later.

        static string[] string5;

        static void Main(string[] args)
        {
            string5 = new string[] { "a", "b", "c" };
        }
    }
}