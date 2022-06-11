using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {

            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            bool isBigger = first > second;
            int sum = 0;

            if (!isBigger)
            {
                foreach (var item in text)
                {
                    if (item > first && item < second)
                    {
                        sum += (int)item;
                    }
                }
            }
            else
            {
                foreach (var item in text)
                {
                    if (item > second && item < first)
                    {
                        sum +=  (int)item;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
