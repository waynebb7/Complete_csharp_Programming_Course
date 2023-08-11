namespace _9._112.AnonymousFunctionsandLambdoExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expression Lambda
            Action debug = () => System.Diagnostics.Debug.WriteLine("Hello world");
            debug();


            // Statement Lambda
            Action debug2 = () =>
            {
                System.Diagnostics.Debug.WriteLine("Hello world");
                System.Diagnostics.Debug.WriteLine("Hello world");
                System.Diagnostics.Debug.WriteLine("Hello world");
            };
            debug2();

            Action<string> debug3 = (s) => System.Diagnostics.Debug.WriteLine(s);
            debug3("Example");
        }
    }
}