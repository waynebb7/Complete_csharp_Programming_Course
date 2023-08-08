namespace _4._39.is_operator
{
    public class Ex1 { }
    public class Ex2 : Ex1 { }


    internal class Program
    {
        static void Main(string[] args)
        {
            Ex2 ex2Object = new Ex2();
            bool b = ex2Object is Ex1;
            System.Diagnostics.Debug.WriteLine(b);


            //bool b = "abc" is string;
            //System.Diagnostics.Debug.WriteLine(b); 
            
            //b = "abc" is int;
            //System.Diagnostics.Debug.WriteLine(b);
        }
    }
}