using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Plant plant;
            Exhibition exhibition = new Exhibition();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var rarity = int.Parse(input[1]);
                plant = new Plant(name, rarity, new List<double>());
                exhibition.AddPlants(plant);
            }

            var command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] info = command
                    .Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                string action = info[0];
                string name = info[1];

                switch (action)
                {
                    case "Rate":
                        double rating = double.Parse(info[2]);
                        exhibition.Rate(name, rating);
                        break;
                    case "Update":
                        int newRarity = int.Parse(info[2]);
                        exhibition.Update(name, newRarity);
                        break;
                    case "Reset":
                        exhibition.Reset(name);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(exhibition.ToString());
        }
    }
    public class Plant
    {
        public Plant(string name, int rarity, List<double> rate)
        {
            Name = name;
            Rarity = rarity;
            Rate = rate;
        }

        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<double> Rate { get; set; }
    }

    public class Exhibition
    {
        private List<Plant> plants = new List<Plant>();

        public void AddPlants(Plant plant)
        {
            plants.Add(plant);
        }

        public void Rate(string name, double rating)
        {
            if (plants.Any(p => p.Name == name))
            {
                foreach (var item in plants.Where(p => p.Name == name))
                {
                    item.Rate.Add(rating);
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        public void Update(string name, int newRarity)
        {
            if (plants.Any(p => p.Name == name))
            {
                foreach (var item in plants.Where(p => p.Name == name))
                {
                    item.Rarity = newRarity;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        public void Reset(string name)
        {
            if (plants.Any(p => p.Name == name))
            {
                foreach (var item in plants.Where(p => p.Name == name))
                {
                    item.Rate.Clear();
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Plants for the exhibition:");

            foreach (var item in plants)
            {
                if (!item.Rate.Any())
                {
                    item.Rate.Add(0);
                }
                sb.AppendLine($"- {item.Name}; Rarity: {item.Rarity}; Rating: {item.Rate.Average():f2}");
            }

            return sb.ToString().TrimEnd();
        }
    }


}
