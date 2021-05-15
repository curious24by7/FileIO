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
            string[] lines;
            lines = File.ReadAllLines(PATH);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string lines;
            lines = File.ReadAllText(PATH);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            File.Copy(PATH, COPYPATH);
        }
        public static void DeleteFile()
        {
            File.Delete(PATH);
        }
        public static void ReadFromStreamReader()
        {
            using (StreamReader sr=File.OpenText(PATH))
            {
                string s = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamWriter()
        {
            using (StreamWriter sr = File.AppendText(PATH))
            {
                sr.WriteLine("Hello World .Net is Awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(PATH));
            }
        }
    }
}
