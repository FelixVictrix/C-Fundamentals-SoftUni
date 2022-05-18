using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input != "END")
            {
                bool palindrome = IsPalindrome(input);
                Console.WriteLine(palindrome);

                input = Console.ReadLine();
            }

        }

        static bool IsPalindrome(string input)
        {
            return input.SequenceEqual(input.Reverse());

            //string revers = null;
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    revers += input[i];
            //}

            //if (revers == input)
            //{
            //    return true;
            //}
            //return false;
        }
    }
}
