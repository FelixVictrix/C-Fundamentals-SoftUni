using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            //string regex = @"\b[0-9]{2}(.)[A-Z][a-z]{2}\1[0-9]{4}\b";
            //string regex = @"\b(?<day>\d{2})([.-\/])(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            //MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match item in matches)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

                //Console.WriteLine(item);
            }

        }
    }
}
