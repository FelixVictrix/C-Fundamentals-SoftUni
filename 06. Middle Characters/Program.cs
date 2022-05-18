using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleChar(input);
        }

        static void PrintMiddleChar(string input)
        {
            if (input.Length % 2 == 1)
            {
                Console.WriteLine(input.Substring(input.Length / 2, 1));
            }
            else
            {
                Console.WriteLine(input.Substring((input.Length / 2) - 1, 2));
            }
        }
    }
}
