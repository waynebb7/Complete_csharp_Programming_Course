namespace _4._40.as_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            object obj1 = s1;
            string s2 = obj1 as string;

            System.Diagnostics.Debug.WriteLine(s1);
            System.Diagnostics.Debug.WriteLine(s2);
            
            System.Diagnostics.Debug.WriteLine(s1.GetType());
            System.Diagnostics.Debug.WriteLine(obj1.GetType());
            System.Diagnostics.Debug.WriteLine(s2.GetType());




        }
    }
}