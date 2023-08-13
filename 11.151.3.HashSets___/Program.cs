using System.Collections.Generic;
using System.Diagnostics;

namespace _11._151.HashSets___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> letter1 = new HashSet<string>() { "a", "b", "c" };
            HashSet<string> letter2 = new HashSet<string>() { "d", "e", "f", "a", "b" };

            // Using SymmetricExceptWith with will make the set contain only those elements NOT contained in both sets.
            letter1.SymmetricExceptWith(letter2);

            foreach (string s in letter1)
            {
                Debug.WriteLine(s);
            }
        }
    }
}