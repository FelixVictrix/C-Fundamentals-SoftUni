using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {

            string regex = @"!(?<command>[A-Z][a-z]{3,})!:(\[)(?<message>[A-z]{8,})(\])";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                bool isMatch = Regex.IsMatch(input, regex);
                if (isMatch)
                {
                    MatchCollection match = Regex.Matches(input, regex);
                    List<int> translate = new List<int>();

                    foreach (Match item in match)
                    {
                        string action = item.Groups["command"].ToString();
                        string message = item.Groups["message"].ToString();
                        foreach (var chr in message)
                        {
                            translate.Add(chr);
                        }
                        Console.Write($"{action}: {string.Join(" ",translate)}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }


            }

        }
    }
}
