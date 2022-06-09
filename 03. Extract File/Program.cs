using System;
using System.IO;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            var fileName = Path.GetFileNameWithoutExtension(filePath);
            var fileExtension = Path.GetExtension(filePath);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

            //string filePath = Console.ReadLine();
            //int index = filePath.LastIndexOf('\\');
            //string nameType = filePath.Substring(index + 1);
            //string[] file = nameType.Split(".");

            //Console.WriteLine($"File name: {file[0]}");
            //Console.WriteLine($"File extension: {file[1]}");

        }
    }
}
