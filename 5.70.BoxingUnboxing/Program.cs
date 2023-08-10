namespace _4._70.BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 3;
            float d = num;

            System.Diagnostics.Debug.WriteLine(num);

            //explicit conversion
            float f = 1.5f;
            int example = (int)f;
            System.Diagnostics.Debug.WriteLine(example);

            //boxing
            int example2 = 1;
            object o = example2;

            //unboxing
            int example3 = (int)o;


        }
    }
}