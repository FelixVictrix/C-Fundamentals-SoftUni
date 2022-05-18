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

            for (int i = 0; i < number; i++)
            {
                int currNumber = i;
                if (currNumber % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
