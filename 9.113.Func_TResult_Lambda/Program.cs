namespace _9._113.Func_TResult_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lambda expression using <Func>
            Func<int, int, int> multiply = (x, y) => { return x * y; };
            System.Diagnostics.Debug.WriteLine(multiply(2, 3));
        }
    }
}