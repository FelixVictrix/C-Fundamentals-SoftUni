using System;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] rev = input.ToCharArray();
                rev = rev.Reverse().ToArray();
                Console.Write($"{input} = {string.Join("", rev)}\n");

                input = Console.ReadLine();
            }


        }
    }
}
