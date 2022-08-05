using System;
using System.Collections.Generic;

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
                var input = Console.ReadLine().Split("<->",StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var rarity = double.Parse(input[1]);
                plant= new Plant(name,new List<double>());
                plant.Rarity.Add(rarity);
                exhibition.AddPlants(plant);
            }

        }
    }
    public class Plant
    {
        public Plant(string name, List<double> rarity)
        {
            Name = name;
            Rarity = rarity;
        }

        public string Name { get; set; }
        public List<double> Rarity { get; set; }
    }

    public class Exhibition
    {
        private List<Plant> plants = new List<Plant>();

        public void AddPlants(Plant plant)
        {
            var currPlant = plant.Name.ToString();
            if (plants.Contains(currPlant)
            {

            }
            plants.Add(plant);
        }
    }
}
