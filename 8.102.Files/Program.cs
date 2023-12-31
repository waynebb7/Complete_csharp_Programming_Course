﻿using System.Text;

namespace _8._102.Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREATE FILE 
            //create a variable to hold a file path
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
            //check to see if file named Example.txt exists at path, if not create new file Example.txt
            if(!File.Exists(path))
            {
                File.Create(path);
            }

            //APPEND TO FILE
            //create new FileStream object called fs using path and access the file in FileMode.Append
            FileStream fs = new FileStream(path, FileMode.Append);
            //create new array of data called info and populate with the characters for "Hello World"
            byte[] info = new UTF8Encoding(true).GetBytes("Hello World");
            //write the info array into the FileStream fs
            fs.Write(info, 0, info.Length);
            //close the FileStream object
            fs.Close();

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