namespace _8._99.Read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hit a key: ");
            Console.WriteLine("g = green, r = red, b = blue, w = white");
            int x = Console.Read();
            char userInput = Convert.ToChar(x);

            while (userInput != 'z')
            {
                switch (userInput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break; 

                }
                Console.Clear();
                Console.WriteLine("g = green, r = red, b = blue, w = white");
                x = Console.Read();
                userInput = Convert.ToChar(x);
            }

        }
    }
}