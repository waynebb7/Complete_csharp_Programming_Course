namespace _4._32.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop
            List<string> collection = new List<string>() { "a", "b", "c" };
            for (int i = 0; i < collection.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(collection[i]);
            }
        }
    }
}