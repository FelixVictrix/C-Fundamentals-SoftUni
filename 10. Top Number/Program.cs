using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            IsTopNumber(number);

        }

        static void IsTopNumber(int number)
        {

            for (int i = 1; i <= number; i++)
            {
                string curr = i.ToString();
                bool isOdd = false;
                int sum = 0;

                foreach (var c in curr)
                {
                    if ((int)c % 2 == 1)
                    {
                        isOdd = true;
                    }
                    sum += (int)c;
                }

                if (sum%8==0 && isOdd)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
