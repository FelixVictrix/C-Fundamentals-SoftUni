using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Vowels(input);
        }

        static void Vowels(string input)
        {
            int vowelsCount = 0;
            foreach (var letter in input)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        vowelsCount++;
                        break;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
