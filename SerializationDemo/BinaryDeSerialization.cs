using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    class BinaryDeSerialization
    {
        public const string PATH = @"C:\Users\soham\source\repos\FileIO\SerializationDemo\Example.txt";
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(PATH, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }
    }
}
