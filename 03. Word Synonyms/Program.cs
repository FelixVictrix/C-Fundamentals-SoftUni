using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> diction = new Dictionary<string, List<string>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!diction.ContainsKey(word))
                {
                    diction.Add(word, new List<string>());
                }
                diction[word].Add(synonym);
            }
            foreach (var kvp in diction)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }

        }
    }
}
