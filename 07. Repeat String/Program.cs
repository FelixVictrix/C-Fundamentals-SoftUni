using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Print(input,count);
        }

        private static void Print(string input, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(input);
            }
        }
    }
}
