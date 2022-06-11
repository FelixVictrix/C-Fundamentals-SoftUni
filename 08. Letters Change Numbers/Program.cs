using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                string getNumber = item.Substring(1, item.Length - 2);
                int number = int.Parse(getNumber);
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];

                if (char.IsUpper(firstLetter))
                {
                    double letterPosition = (double)firstLetter - 64;
                    sum += number / letterPosition;
                }
                else
                {
                    double letterPosition = (double)firstLetter - 96;
                    sum += number * letterPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    int letterPosition = (int)lastLetter - 64;
                    sum -= letterPosition;
                }
                else
                {
                    int letterPosition = (int)lastLetter - 96;
                    sum += letterPosition;
                }

            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
