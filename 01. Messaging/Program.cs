using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> intList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            List<char> chrList = text.ToList();

            string message = string.Empty;

            for (int i = 0; i < intList.Count; i++)
            {
                int index = Sum(intList , i);

                if (index > chrList.Count - 1)
                {
                    index = index - chrList.Count;
                }
                message += chrList[index];
                chrList.RemoveAt(index);
            }

            Console.WriteLine(message);

        }

        static int Sum(List<int> intList , int i)
        {
            string numbers = intList[i].ToString();
            int sum = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                string num = numbers[j].ToString();
                sum += int.Parse(num);
            }
            return sum;
        }
    }
}
