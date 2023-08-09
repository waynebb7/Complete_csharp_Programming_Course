using System.Collections.Generic;

namespace _4._68.BooleanFlagTechnique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            List<int> list = new List<int>() { 1, 2, 3 };
            foreach (int i in list)
            {
                if (i == 3)
                {
                    flag = true;
                }

            }
            if (flag)
            {
                System.Diagnostics.Debug.WriteLine("3 was found");
               

            }
        }
    }
}