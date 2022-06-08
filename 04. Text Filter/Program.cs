using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var item in words)
            {
                text = text.Replace(item, new string('*', item.Length));
            }

            Console.WriteLine(text);
        }
    }
}
