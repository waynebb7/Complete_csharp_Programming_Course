using Microsoft.VisualBasic;

namespace _6._76.DateTimeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine(DateTime.Now);

            DateTime date = DateTime.Now;
            System.Diagnostics.Debug.WriteLine(date);
           
            date = new DateTime(2020,1,19);
            System.Diagnostics.Debug.WriteLine(date);

            //TIMESPAN
            TimeSpan timeSpan = new TimeSpan();
            System.Diagnostics.Debug.WriteLine(timeSpan);

            timeSpan = new TimeSpan(1,2,0);
            System.Diagnostics.Debug.WriteLine(timeSpan);
            System.Diagnostics.Debug.WriteLine(timeSpan.Hours);
            System.Diagnostics.Debug.WriteLine(timeSpan.Minutes);
            System.Diagnostics.Debug.WriteLine(timeSpan.Seconds);
            System.Diagnostics.Debug.WriteLine(timeSpan.Milliseconds);
            System.Diagnostics.Debug.WriteLine(timeSpan.Days);
            System.Diagnostics.Debug.WriteLine(timeSpan.TotalMilliseconds);

            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dd/MM/yy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss dddd, dd MMMM yyyy"));
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm tt"));
            
            //UTC time
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString("HH:mm tt"));
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToString("HH:mm tt"));

            //Convert Local Time to UTC time
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToUniversalTime().ToString("HH:mm tt"));

            //Convert UTC time to Local Time
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.ToLocalTime().ToString("HH:mm tt"));

            //identify the time kind. Is it UTC or Local?
            System.Diagnostics.Debug.WriteLine(DateTime.UtcNow.Kind);
            System.Diagnostics.Debug.WriteLine(DateTime.Now.Kind);


        }
    }
}