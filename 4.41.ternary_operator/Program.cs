namespace _4._41.ternary_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x =5;
            int value = 6;
            var isGreater = x > value ? true : false;

            System.Diagnostics.Debug.WriteLine(isGreater);
            //if(x > value)
            //{
            //    isGreater = true;
            //}
            //else
            //{
            //    isGreater = false;
            //}

        }
    }
}