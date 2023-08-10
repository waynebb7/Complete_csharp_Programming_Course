namespace _15._189.XMLTags
{
    /// <summary>
    /// The <c>Program</c>Class we use for tutorials.
    /// </summary>
    /// <remarks>
    /// More information
    /// </remarks>
    /// <include file='docs.xml' path='docs/members[@name="program"]/Program/*'/>
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">An int</param>
        /// <param name="b">An int</param>
        /// <example>
        /// <code>
        /// int c = Program.Add(1, 2);
        /// </code>
        /// </example>
        /// <returns>The sum of two integers</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// Gets the value of Val.
        /// </value>
        /// <remarks><para>More info goes here.</para></remarks>
        public static string Val { get; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="System.DivideByZeroException">Thrown when we attempt to divide by zero</exception>
        /// <see cref="cref="Program.Divide(int, int)"/> to divide integers
        /// <seealso cref="cref="Program.Divide(int,int)"/>
        public static int Divide(int a, int b)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="message">The message to print, can be any type</typeparam>
        /// <returns></returns>
        /// Prints a message <typeparamref name="message" /> to the console
        public static bool PrintMessage(Task message)
        {

        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Add</term>
        /// <description>addition</description>
        /// </item>
        /// <item>
        /// <term>Subtract</term>
        /// <description>subtraction</description>
        /// </item>
        /// <item>
        /// <term>Multiply</term>
        /// <description>multiplicationn</description>
        /// </item>
        /// <item>
        /// <term>Divide</term>
        /// <description>division</description>
        /// </item>
        /// </list>
        /// </summary>
        public class Math
        {

        }
    }
}