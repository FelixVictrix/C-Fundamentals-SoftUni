using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery_Dic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantsRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int rarity = int.Parse(input[1]);
                AddPlant(plantsRarity, plantsRating, name, rarity);
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] info = command
                    .Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string action = info[0];
                string name = info[1];

                switch (action)
                {
                    case "Rate":
                        int rate = int.Parse(info[2]);
                        Rate(plantsRating, name, rate);
                        break;
                    case "Update":
                        int newRarity = int.Parse(info[2]);
                        Update(plantsRarity, name, newRarity);
                        break;
                    case "Reset":
                        Reset(plantsRating, name);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in plantsRarity)
            {
                Console.Write($"- {item.Key}; Rarity: {item.Value};");
                foreach (var plant in plantsRating.Where(p=> p.Key == item.Key))
                {
                    if (plant.Value.Any())
                    {
                        double aver = plant.Value.Average();
                        Console.Write($" Rating: {aver:f2}");
                    }
                    else
                    {
                        double aver = 0;
                        Console.Write($" Rating: {aver:f2}");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        static void Reset(Dictionary<string, List<double>> plantsRating, string name)
        {
            if (plantsRating.ContainsKey(name))
            {
                plantsRating[name].Clear();
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static void Update(Dictionary<string, int> plantsRarity, string name, int newRarity)
        {
            if (plantsRarity.ContainsKey(name))
            {
                plantsRarity[name] = newRarity;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static void Rate(Dictionary<string, List<double>> plantsRating, string name, int rate)
        {
            if (plantsRating.ContainsKey(name))
            {
                plantsRating[name].Add(rate);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static void AddPlant(Dictionary<string, int> plantsRarity, Dictionary<string, List<double>> plantsRating, string name, int rarity)
        {
            if (!plantsRarity.ContainsKey(name))
            {
                plantsRarity.Add(name, 0);
                plantsRating.Add(name, new List<double>());
            }
            plantsRarity[name] = rarity;
        }
    }
}
