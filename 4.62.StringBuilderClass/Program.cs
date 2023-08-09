using System.Text;

namespace _4._62.StringBuilderClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WORKING WITH STRINGBUILDER
            StringBuilder stringBuilder = new StringBuilder();
            System.Diagnostics.Debug.WriteLine("This is the stringBuilder object: " + stringBuilder.ToString());

            //stringBuilder.Append
            stringBuilder.Append("Hello ");
            System.Diagnostics.Debug.WriteLine("This is the stringBuilder object: " + stringBuilder.ToString());
            //stringBuilder.Append loop
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append(i + " Hello ");
            }
            System.Diagnostics.Debug.WriteLine("This is the stringBuilder object: " + stringBuilder.ToString());
            stringBuilder.Clear();
            System.Diagnostics.Debug.WriteLine("This is the stringBuilder object: " + stringBuilder.ToString());

            //stringBuilder.AppendLine loop
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.AppendLine(i + " Hello ");
            }
            System.Diagnostics.Debug.WriteLine("This is the stringBuilder object: " + stringBuilder.ToString());

            //create new stringBuilder object sb
            StringBuilder sb = new StringBuilder("Wayne World");
            //stringBuilder.Remove
            sb.Remove(6, 5);
            System.Diagnostics.Debug.WriteLine("This is the stringBuilder object: " + sb.ToString());

            //create new stringBuilder object sb2
            StringBuilder sb2 = new StringBuilder("Banana Bunch was here");
            System.Diagnostics.Debug.WriteLine("Original text:    " + sb2.ToString());

            //stringBuilder.Replace
            sb2.Replace('a', 'i');
            System.Diagnostics.Debug.WriteLine("Replacement text: " + sb2.ToString());

            sb2.Replace(' ', '_');
            System.Diagnostics.Debug.WriteLine("Replacement text: " + sb2.ToString());

            //stringBuilder.Length (returns length of string)
            System.Diagnostics.Debug.WriteLine(sb2.Length.ToString());

            //WORKING WITH STRINGS AGAIN
            //create string to work with
            string s6 = "abc";
            //string.IndexOf() returns the index of the character
            System.Diagnostics.Debug.WriteLine("IndexOf used to find the IndexOf letter b in string abc. Letter b is in index position: " + s6.IndexOf("b"));

            //string.ToUpper()
            System.Diagnostics.Debug.WriteLine(s6.ToUpper());

            //string.ToLower()
            System.Diagnostics.Debug.WriteLine(s6.ToLower());

            //string.Insert()
            System.Diagnostics.Debug.WriteLine(s6.Insert(3, "d"));

            //string.Remove()
            System.Diagnostics.Debug.WriteLine(s6.Remove(3));

            //string.Trim()
            System.Diagnostics.Debug.WriteLine(s6.Trim('a'));

            //string.Replace()
            System.Diagnostics.Debug.WriteLine(s6.Replace('b', 'f')); //character
            System.Diagnostics.Debug.WriteLine(s6.Replace("bc","gh")); //string

            //string.Split()
            string s = "The quick brown fox jumps over the lazy array"; //string
            string[] sArray = s.Split(' ');                             //uses split to split up the string using the spaces as the delimiter and puts the separate words in the array sArray
            System.Diagnostics.Debug.WriteLine(s);
            
            foreach (string item in sArray)                             //for each item in the array sArray write to output window
            {
                System.Diagnostics.Debug.WriteLine(item);

            }

            //create new string to work on
            string q = "This is a string";
            //string.Substring() to extract substring
            System.Diagnostics.Debug.WriteLine(q.Substring(4,5));

            //string.IsNullOrEmpty
            string w = null;
            System.Diagnostics.Debug.WriteLine(string.IsNullOrEmpty(w));


        }
    }
}