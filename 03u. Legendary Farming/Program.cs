using System;
using System.Collections.Generic;
using System.Linq;

namespace _03u._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> materials = new Dictionary<string, int>
            {
                { "shards" , 0},
                { "fragments" , 0 },
                { "motes" , 0}
                };

            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool stop = false;

            while (!stop)
            {
                string[] info = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < info.Length; i += 2)
                {
                    string type = info[i + 1];
                    int quantity = int.Parse(info[i]);

                    if (type == "fragments" || type == "shards" || type == "motes")
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
                    if (materials.Any(x => x.Value >= 250))
                    {
                        stop = true;
                        break;
                    }
                }

            }
            if (materials["fragments"] >= 250)
            {
                materials["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained");
            }
            else if (materials["shards"] >= 250)
            {
                materials["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained");
            }
            else if (materials["motes"] >= 250)
            {
                materials["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained");
            }
            foreach (var item in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
