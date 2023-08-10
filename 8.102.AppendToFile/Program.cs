using System.Text;

namespace _8._102.AppendToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part of 8.102.CreateFile app so the file is known to be available
            //create a variable to hold a file path
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";

            //APPEND TO FILE
            //create new FileStream object called fs using path and access the file in FileMode.Append
            FileStream fs = new FileStream(path, FileMode.Append);

            //create new array of data called info and populate with the characters for "Hello World"
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World");

            //write the info array into the FileStream fs
            fs.Write(info, 0, info.Length);

            //close the FileStream object
            fs.Close();                        
        }
    }
}