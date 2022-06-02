using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                string product = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(product))
                {
                    dictionary.Add(product, 0);
                }
                dictionary[product] += quantity;

                input = Console.ReadLine();
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
