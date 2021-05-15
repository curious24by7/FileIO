using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        public const string PATH = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
        public const string COPYPATH = @"C:\Users\soham\source\repos\FileIO\FileIO\xyz.txt";
        static void Main(string[] args)
        {
            //FileExists();
            //ReadAllLines();
            //FileCopy();
            //DeleteFile();
            //ReadFromStreamReader();
            WriteUsingStreamWriter();
            Console.ReadKey();
        }
        public static void FileExists()
        {
            if (File.Exists(PATH))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }
        public static void ReadAllLines()
        {
            if (File.Exists(PATH))
            {
                string[] lines;
                lines = File.ReadAllLines(PATH);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
            }
            else
                Console.WriteLine("File doesn't exists");
        }
        public static void ReadAllText()
        {
            if (File.Exists(PATH))
            {
                string lines;
                lines = File.ReadAllText(PATH);
                Console.WriteLine(lines);
            }
            else
                Console.WriteLine("File doesn't exists");
           
        }
        public static void FileCopy()
        {
            if (File.Exists(PATH))
            {
                File.Copy(PATH, COPYPATH);
            }
            else
                Console.WriteLine("File doesn't exists");
        }
        public static void DeleteFile()
        {
            if (File.Exists(PATH))
            {
                File.Delete(PATH);
                Console.WriteLine("File Deleted Successfully");
            }
            else
                Console.WriteLine("File doesn't exists");
          
        }
        public static void ReadFromStreamReader()
        {
            if (File.Exists(PATH))
            {
                using (StreamReader sr = File.OpenText(PATH))
                {
                    string s = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
                Console.WriteLine("File doesn't exists");
            
        }
        public static void WriteUsingStreamWriter()
        {
            if (File.Exists(PATH))
            {
                using (StreamWriter sr = File.AppendText(PATH))
                {
                    sr.WriteLine("Hello World .Net is Awesome");
                    sr.Close();
                    Console.WriteLine(File.ReadAllText(PATH));
                }
            }
            else
                Console.WriteLine("File doesn't exists");
        }
    }
}
