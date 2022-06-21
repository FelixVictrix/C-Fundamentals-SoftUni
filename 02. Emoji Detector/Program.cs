using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digits = @"\d+";
            string emoji = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            int coolThreshold = 1;

            MatchCollection textMatches = Regex.Matches(text, emoji);
            MatchCollection digitsMatches = Regex.Matches(text, digits);

            foreach (Match match in digitsMatches)
            {
                foreach (var dig in match.Value)
                {
                    coolThreshold *= int.Parse(dig.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{textMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match item in textMatches)
            {
                int curSum = 0;

                foreach (var str in item.Value)
                {
                    if (str != ':' && str != '*')
                    {
                        curSum += (int)str;
                    }
                }
                if (curSum >= coolThreshold)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
