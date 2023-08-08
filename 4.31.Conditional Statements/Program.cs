namespace _4._31.Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if statement
            bool complete = true;
            if (complete)
            {
                Console.WriteLine("Boolean statement was true");
                System.Diagnostics.Debug.WriteLine("Boolean statement was true");

                int x = 5;
                Console.WriteLine(x);
            }

            // else if statement
            bool start = false;
            bool end = true;
            if (start)
            {
                Console.WriteLine("Start is true.");
            }else if (end)
            {
                Console.WriteLine("End is true.");
            }

            //else clause
            bool yes = false;
            bool no = false;
            if (yes)
            {
                Console.WriteLine("Yes is True");
            }else if (no)
            {
                Console.WriteLine("No is True");
            }else 
            { 
                Console.WriteLine("Something else here");
            }

        }
    }
}