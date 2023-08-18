namespace _16._195.Searching.BinarySearchMethod
{
    internal class Program
    {
        static int binarySearch(List<int> elements, int x)
        {
            int start = 0;
            int stop = elements.Count - 1;
            int middle = (int)((start + stop) / 2);
            while (elements[middle] != x && start < stop)
            {
                if (x < elements[middle])
                {
                    stop = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }

                middle = (int)((start + stop) / 2);
            }

            return (elements[middle] != x) ? -1 : middle;
        }

        static void Main(string[] args)
        {

        }
    }
}