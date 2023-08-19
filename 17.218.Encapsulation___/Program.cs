namespace _17._218.Encapsulation___
{
    internal class Program
    {
        private static int number1 = 3;
        private static int number2 = 5;

        public static int MultiplyWithExtras(int num1, int num2)
        {
            return num1 * num2 + num2;
        }

        public class MainClass
        {
            static void Main(string[] args)
            {
                Program.MultiplyWithExtras(1, 2);
            }
        }
    }
}