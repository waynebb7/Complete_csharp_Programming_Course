namespace _9._117.OptionalParameters
{
    internal class Program
    {

        static void PrintMessage(string message = "Hello World")
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
        static void Main(string[] args)
        {
            PrintMessage();
            PrintMessage("My Message");
        }
    }
} 