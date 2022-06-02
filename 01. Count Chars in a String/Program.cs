using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();


            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i].ToString();
                if (curr == " ")
                {
                    continue;
                }
                if (!dic.ContainsKey(curr))
                {
                    dic.Add(curr, 0);
                }
                dic[curr]++;
            }
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
