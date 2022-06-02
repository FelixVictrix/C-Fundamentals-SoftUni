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
            bool isTrue = true;

            while (isTrue)
            {
                var input = Console.ReadLine().ToLower().Split();
                AddDic(input, materials);
                isTrue = materials.All(m => m.Value < 250);
            }

            var legendary = materials.FirstOrDefault(m => m.Value >= 250);
            IsLegendary(legendary, materials);

            materials.OrderByDescending(m => m.Value);
            foreach (var kvp in materials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
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

        static void AddDic(string[] input, Dictionary<string, int> materials)
        {
            for (int i = 0; i < input.Length; i += 2)
            {
                var type = input[i + 1];
                var quantity = int.Parse(input[i]);

                if (!materials.ContainsKey(type))
                {
                    materials.Add(type, 0);
                }
                materials[type] += quantity;
            }
        }
    }
}
