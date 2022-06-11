using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            // abv>1>1>2>2asdasd
            // abv>>>>dasd
            string input = Console.ReadLine();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (power > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    power -= 1;
                    i -= 1;
                }
                else if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                }
            }

            Console.WriteLine(input);
        }
    }
}
