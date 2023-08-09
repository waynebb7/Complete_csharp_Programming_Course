namespace _7._86.ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Diagnostics.Debug.WriteLine("Hello World");
            }

            string example = "abd";
            //moving forwards
            for (int i = 0; i < example.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine(example[i]);
            }
            //moving backwards
            for (int i = example.Length - 1; i >= 0; i--)
            {
                System.Diagnostics.Debug.WriteLine(example[i]);
            }

            //using a or loop without any statements inside
            int j = 0;
            for(; ; )
            {
                if(j < 4)
                {
                    System.Diagnostics.Debug.WriteLine(j.ToString());
                    j++;
                }
            }
        }
    }
}