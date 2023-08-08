namespace _4._42.null_coalescing_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable = left operand ?? right operand
            // variable = if not null ?? if null

            object obj = null;
            object obj2 = obj ?? new object();
        }
    }
}