namespace _16._194.Searching.LinearSeachMethod
{
    internal class Program
    {

        static int linearSearch(List<int> elements, int x)
        {
            int length = elements.Count;
            for (int i = 0; i < length; i++)
            {
                if (elements[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {

        }
    }
}