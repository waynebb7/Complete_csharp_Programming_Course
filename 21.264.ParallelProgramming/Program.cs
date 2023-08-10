using System.Net;
using System.Threading.Tasks;

namespace _21._264.ParallelProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Note that this is obsolete now.
            //Parallel.Invoke(
            //    () => new WebClient().DownloadFile("http://www.google.com", "google.html"),
            //    () => new WebClient().DownloadFile("http://www.yahoo.com", "yahoo.html"),
            //    );

            for (int i = 0; i < 200; i++)
            {
                System.Diagnostics.Debug.WriteLine("Hello World!!!!!!!!!!!!!!!!!!");
            }

            // A parallel FOR loop
            Parallel.For(0, 200, i => System.Diagnostics.Debug.WriteLine("Hello World"));
        }
    }
}