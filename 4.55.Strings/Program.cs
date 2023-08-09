namespace _4._55.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string emptyString = string.Empty;

            System.Diagnostics.Debug.WriteLine(s1);
            System.Diagnostics.Debug.WriteLine(emptyString);


            string s2 = "Hey";
            string s3 = "There";
            string s4 = s2 + " " + s3;
            System.Diagnostics.Debug.WriteLine(s4);

            string s5 = "abc";
            string s6 = "abc";
            System.Diagnostics.Debug.WriteLine(s5 == s6);
            // preferred method of checking equality
            System.Diagnostics.Debug.WriteLine(string.Equals(s5, s6));

            // using th verbatim identifier symbol @
            string @if = "Hello World";

            // newline escape sequence is activated
            System.Diagnostics.Debug.WriteLine("a\nb");
            // newline escape sequence is not activated and all text is read purely as text
            System.Diagnostics.Debug.WriteLine("@a\nb");

            //INTERPOLATED STRINGS
            //using $ sign means that the string is an interpolated string
            string name = "Wayne";
            System.Diagnostics.Debug.WriteLine($"Hi my name is {name} ");

            //SUBSTRINGS
            string example = "abc";
            System.Diagnostics.Debug.WriteLine(example.Contains("bc"));
            System.Diagnostics.Debug.WriteLine(example.Contains("d"));
            System.Diagnostics.Debug.WriteLine(example.Substring(1));
            System.Diagnostics.Debug.WriteLine(example.Substring(0,2));

            //ESCAPE SEQUENCES
            System.Diagnostics.Debug.WriteLine("Wayne said \"Go write some code\"");        // \"
            System.Diagnostics.Debug.WriteLine("a\\b");                                     // \\
            //Console.WriteLine("\a");                                                        // \a alert should play a beep
            System.Diagnostics.Debug.WriteLine("Hello\rWorld");                             // \r carriage return
            System.Diagnostics.Debug.WriteLine("Hello\tWorld");                             // \t horizontal tab

            //STRING FORMATTING using IFormatable
            int price = 100;
            System.Diagnostics.Debug.WriteLine(string.Format("The item costs {0:C} ", price));

            float percent = 0.5f;
            System.Diagnostics.Debug.WriteLine(string.Format("The task is {0:P} complete", percent));


        }
    }
}