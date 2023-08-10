using System.Text;

namespace _8._102.CreateFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREATE FILE
            //create a variable to hold a file path
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";

            //check to see if file named Example.txt exists at path, if not create new file Example.txt
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}