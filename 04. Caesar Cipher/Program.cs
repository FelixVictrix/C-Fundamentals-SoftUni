using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (var letter in text)
            {
                int encrypted = ((int)letter + 3);
                sb.Append((char)encrypted);
            }
            Console.WriteLine(sb);
        }
    }
}
