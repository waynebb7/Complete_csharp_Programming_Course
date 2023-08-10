namespace _4._84.ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if (3 > 5)
            //{
            //    System.Diagnostics.Debug.WriteLine("3 is less than 5");
            //}
            //else if (2 > 4)
            //{
            //    System.Diagnostics.Debug.WriteLine("2 is less than 4");

            //}
            //else
            //{
            //    System.Diagnostics.Debug.WriteLine("This was hit");
            //}

            //if (1 < 2)
            //{
            //    System.Diagnostics.Debug.WriteLine("1 is less than 2");

            //}
            //if (2 < 3)
            //{
            //    System.Diagnostics.Debug.WriteLine("2 is less than 3");
            //}

            //nested
            if(1 < 2)
            {
                if (true)
                {
                    System.Diagnostics.Debug.WriteLine("If statement was hit!");

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Else was hit!");

                }
            }

        }
    }
}