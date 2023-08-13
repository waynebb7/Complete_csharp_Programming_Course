using System.Diagnostics;

namespace _11._149.Enums___
{
    internal class Program
    {
        enum Weekday { Monday = 1, Tuesday, Wednesday,  Thursday, Friday, Saturday, Sunday };

        static void Main(string[] args)
        {
            Debug.WriteLine(Enum.GetName(typeof(Weekday), 6));

            foreach (string s in Enum.GetNames(typeof(Weekday)))
            {
                Debug.WriteLine(s);
            }

            foreach (int i in Enum.GetValues(typeof(Weekday)))
            {
                Debug.WriteLine(i);
            }

        }
    }
}