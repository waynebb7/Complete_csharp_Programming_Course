namespace _8._101.UserInputMask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease enter a number: ");
            do
            {
                string userInput = Console.ReadLine();
                int number;

                if (!int.TryParse(userInput, out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You entered invalid input!");
                    Console.ResetColor();
                    Console.WriteLine("\nPlease enter a number: ");

                }
                else
                {
                    Console.WriteLine("\nThanks! Enter another number: ");
                }
            } while (true);
        }
    }
}