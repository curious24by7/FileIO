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
            string path = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");
        }
        public static void ReadAllLines()
        {
            string path = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string path = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void FileCopy()
        {
            string path = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
            string copypath = @"C:\Users\soham\source\repos\FileIO\FileIO\xyz.txt";
            File.Copy(path, copypath);
        }
        public static void DeleteFile()
        {
            string path = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\xyz.txt";
            File.Delete(path);
        }
        public static void ReadFromStreamReader()
        {
            string path = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
            using (StreamReader sr=File.OpenText(path))
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
            string path = "C:\\Users\\soham\\source\\repos\\FileIO\\FileIO\\Example.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World .Net is Awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
    
}
