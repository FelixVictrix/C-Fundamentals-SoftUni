using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string barcode = @"@#+([A-Z][A-Za-z\d]{4,}[A-Z])@#+";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, barcode);

                if (matches.Any())
                {
                    foreach (Match item in matches)
                    {
                        if(item.Value.Any(c=> char.IsDigit(c)))
                        {
                            var digits = item.Value.Where(c=> char.IsDigit(c)).Select(c=> c).ToArray();
                            Console.WriteLine($"Product group: {string.Join("",digits)}");
                        }
                        else
                        {
                            Console.WriteLine("Product group: 00");
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}
