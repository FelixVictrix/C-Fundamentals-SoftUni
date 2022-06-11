using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                int firstIndexName = text.IndexOf('@');
                int lastIndexName = text.IndexOf('|');
                int firstIndexAge = text.IndexOf('#');
                int lastIndexAge = text.IndexOf('*');

                string name = text.Substring(firstIndexName + 1, lastIndexName - firstIndexName - 1);
                string age = text.Substring(firstIndexAge + 1, lastIndexAge - firstIndexAge - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }

        }
    }
}
