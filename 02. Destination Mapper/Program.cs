using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {

            string regex = @"(=|\/)(?<destination>[A-Z][A-z]{2,})\1";
            string text = Console.ReadLine();

            MatchCollection match = Regex.Matches(text, regex);
           
            int points = 0;
            List<string> listMatch = new List<string>();

            foreach (Match item in match)
            {
                var curr = item.Groups["destination"];
                points += curr.Value.Length;
                listMatch.Add(curr.ToString());
               
            }
            Console.WriteLine($"Destinations: {string.Join(", ",listMatch)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
