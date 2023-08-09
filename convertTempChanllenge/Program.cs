using System.Security.Cryptography.X509Certificates;

namespace convertTempChanllenge
{
    internal class Program
    {
        public static float MathChallenge(float fahrenheit)
        {
            return ((fahrenheit - 32) / 9 * 5);
        }

        static void Main(string[] args)
        {
            float fahrenheit = -32;
            float celsius = MathChallenge(fahrenheit);
            System.Diagnostics.Debug.WriteLine(celsius);
        }
    }
}