namespace _4._44.typeof_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            System.Diagnostics.Debug.WriteLine(typeof(int));
            System.Diagnostics.Debug.WriteLine(x.GetType());
        }
    }
}