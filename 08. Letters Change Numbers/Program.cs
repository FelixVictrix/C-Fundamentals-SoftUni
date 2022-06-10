using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

             double sum = 0;

            foreach (var item in input)
            {
                string num = item.Substring(1, item.Length - 2);
                int number = int.Parse(num);
                char first = item[0];
                char last = item[item.Length - 1];

                if (char.IsUpper(first))
                {
                    double letterPosition = (double)first - 64;
                    sum += number / letterPosition;
                }
                else
                {
                    double letterPosition = (double)first - 96;
                    sum += number * letterPosition;
                }

                if (char.IsUpper(last))
                {
                    int letterPosition = (int)last - 64;
                    sum -= letterPosition;
                }
                else 
                {
                    int letterPosition = (int)last - 96;
                    sum += letterPosition;
                }

                //P34562Z q2576f H456z
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
