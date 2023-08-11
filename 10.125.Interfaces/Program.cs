namespace _10._125.Interfaces
{
    public class Program : IExample, ISecondInterface
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.Example();
            pg.Example2();
            pg.Example3("Hello", "Wayne");
        }

        public void Example()
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }
    }

    interface IExample
    {
        void Example();

        int Example2();

        string Example3(string string1, string string2);
    }

    interface ISecondInterface
    {

    }
}