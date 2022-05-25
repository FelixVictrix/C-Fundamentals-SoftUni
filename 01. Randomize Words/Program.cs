using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < words.Length-1; i++)
            {
                
                string a = rnd.Next(minValue,maxValue);

            }

        }
    }
}
