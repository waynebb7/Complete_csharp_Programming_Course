namespace _9._118.ExtensionMethods
{
    public static class Program
    {
        public static bool GreaterThan(this int i, int val)
        {
            if (i > val)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine(2.GreaterThan(1));
        }
    }
}