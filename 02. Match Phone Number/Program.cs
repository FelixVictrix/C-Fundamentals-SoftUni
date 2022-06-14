using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

           // var regex = @"\+[359]+([ -])[2]\1[0-9]{3}\1[0-9]{4}\b";
            var phones = Console.ReadLine();
            MatchCollection matches = Regex.Matches(phones, @"\+[359]+([ -])2\1[0-9]{3}\1[0-9]{4}\b");

            var matchedPhones = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));

            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item + " ");
            //}

        }
    }
}
