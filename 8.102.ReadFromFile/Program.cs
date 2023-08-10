using System.Text;

namespace _8._102.ReadFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //part of 8.102.CreateFile app so the file is known to be available
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";

            //READ FROM FILE
            //create StreamReader object sr and read file at path
            StreamReader sr = new StreamReader(path);

            //read all text in file and load into variable string fileText
            string fileText = sr.ReadToEnd();

            //output variable fileText contents to output window
            System.Diagnostics.Debug.WriteLine(fileText);
        }
    }
}