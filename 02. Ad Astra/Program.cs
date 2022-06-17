using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            string regex = @"([#\|])(?<name>[A-z, ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            MatchCollection matches = Regex.Matches(text, regex);

            var totalCalories = 0;

            foreach (Match item in matches)
            {
                totalCalories += int.Parse(item.Groups["calories"].Value);
            }

            var days = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in matches)
            {
                var name = item.Groups["name"].Value;
                var date = item.Groups["date"].Value;
                var calories = item.Groups["calories"].Value;

                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }

        }
    }
}
