using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }

        }
    }
}
