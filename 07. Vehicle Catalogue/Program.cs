using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            //{type}/{brand}/{model}/{horse power / weight}
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] carInf = input
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = carInf[0];
                string brand = carInf[1];
                string model = carInf[2];

                Vehicle vehicle = null;

                if (type == "Car")
                {
                    int horsePower = int.Parse(carInf[3]);
                    vehicle = new Cars(brand, model, horsePower);

                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(carInf[3]);
                    vehicle = new Trucks(brand, model, weight);
                }
                catalog.Collections.Add(vehicle);

                input = Console.ReadLine();
            }

            var catalogs = catalog.Collections.OrderBy(x => x.Brand).ToList();

            Console.WriteLine($"Cars: ");
            foreach (Cars vehicle in catalogs.Where(c => c.GetType().Name == "Cars"))
            {
                Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
            }
            Console.WriteLine($"Trucks: ");
            foreach (Trucks trck in catalogs.Where(c => c.GetType().Name == "Trucks"))
            {
                Console.WriteLine($"{trck.Brand}: {trck.Model} - {trck.Weight}kg");
            }

        }
    }
    class Catalog
    {
        public Catalog()
        {
            Collections = new List<Vehicle>();
        }

        public List<Vehicle> Collections { get; set; }

    }
    class Vehicle
    {
        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
    }
    class Cars : Vehicle
    {
        public Cars(string brand, string model, double horsePower)
            : base(brand, model)
        {
            HorsePower = horsePower;
        }
        public double HorsePower { get; set; }
    }
    class Trucks : Vehicle
    {
        public Trucks(string brand, string model, double weight)
            : base(brand, model)
        {
            Weight = weight;
        }
        public double Weight { get; set; }
    }
}
