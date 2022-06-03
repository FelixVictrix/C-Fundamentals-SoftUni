using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> materials = new Dictionary<string, int>();
            //{
            //    { "shards",0 },
            //    { "fragments",0 },
            //    {"motes",0 }
            //};
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isTrue = true;

            while (isTrue)
            {
                var input = Console.ReadLine().ToLower().Split();
                AddDic(input, materials, junk);
                isTrue = materials.All(m => m.Value < 250);
            }

            var legendary = materials.FirstOrDefault(m => m.Value >= 250);
            IsLegendary(legendary, materials);

        
                if (materials)
                {
                    foreach (var kvp in materials.OrderBy(m => m.Value))
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
                else
                {
                    foreach (var kvp in materials.OrderByDescending(m => m.Value))
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
            

            foreach (var keyValuePair in junk.OrderByDescending(j => j.Key))
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }

        }

        static void IsLegendary(KeyValuePair<string, int> legendary, Dictionary<string, int> materials)
        {
            string isLegend = null;
            switch (legendary.Key)
            {
                case "shards":
                    isLegend = "Shadowmourne";
                    break;
                case "fragments":
                    isLegend = "Valanyr";
                    break;
                case "motes":
                    isLegend = "Dragonwrath";
                    break;
            }
            Console.WriteLine($"{isLegend} obtained!");
            materials[legendary.Key] -= 250;
        }

        static void AddDic(string[] input, Dictionary<string, int> materials, Dictionary<string, int> junk)
        {
            for (int i = 0; i < input.Length; i += 2)
            {
                var type = input[i + 1];
                var quantity = int.Parse(input[i]);

                if (type == "shards" || type == "motes" || type == "fragments")
                {
                    if (!materials.ContainsKey(type))
                    {
                        materials.Add(type, 0);
                    }
                    materials[type] += quantity;
                }
                else
                {

                    if (!junk.ContainsKey(type))
                    {
                        junk.Add(type, 0);
                    }
                    junk[type] += quantity;
                }

                if (materials.Any(m => m.Value >= 250))
                {
                    break;
                }
            }
        }
    }
}
