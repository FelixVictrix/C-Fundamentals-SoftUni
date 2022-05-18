using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

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
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        vowelsCount++;
                        break;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
