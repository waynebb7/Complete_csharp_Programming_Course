namespace _9._115.MethodOverriding
{
    public class Example
    {
        public void PrintHelloWorld()
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
        }
    }

    public class Example2 : Example
    {
        public void PrintHelloWorld()
        {
            System.Diagnostics.Debug.WriteLine("Hi World");
        }


        public static void Main(string[] args)
        {
            Example2 ex = new Example2();
            ex.PrintHelloWorld();
        }
    }
}