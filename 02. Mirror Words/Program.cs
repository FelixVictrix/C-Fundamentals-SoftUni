using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(@|#)(?<first>[A-z]{3,})(##|@@)(?<second>[A-z]{3,})\1";
            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, regex);
            List<string> list = new List<string>();

            foreach (Match item in match)
            {
                var current = item.Groups["first"].ToString();
                var next = item.Groups["second"].ToString();
                var reverse = new string(next.Reverse().ToArray());

                if (current == reverse)
                {
                    string pair = current + " <=> " + next;
                    list.Add(pair);
                }

            }

            Console.WriteLine($"{match.Count} word pairs found!");
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
