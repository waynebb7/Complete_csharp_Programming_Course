namespace _4._67.LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completed = false;
            System.Diagnostics.Debug.WriteLine(!completed);
            
            //AND
            System.Diagnostics.Debug.WriteLine(true & true);
            System.Diagnostics.Debug.WriteLine(true & false);

            //OR
            System.Diagnostics.Debug.WriteLine(true | true);
            System.Diagnostics.Debug.WriteLine(true | false);
            System.Diagnostics.Debug.WriteLine(false | false);

            //short circuiting logical AND and logical OR
            //AND
            System.Diagnostics.Debug.WriteLine(true && true);
            System.Diagnostics.Debug.WriteLine(true && false);

            //OR
            System.Diagnostics.Debug.WriteLine(true || true);
            System.Diagnostics.Debug.WriteLine(true || false);
            System.Diagnostics.Debug.WriteLine(false || false);


        }
    }
}