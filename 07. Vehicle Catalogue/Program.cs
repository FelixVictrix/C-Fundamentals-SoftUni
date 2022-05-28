using System;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Vehicle car = new Cars();

        }
    }
    class Catalog
    {
        private List<Vehicle> collections;

        public Catalog()
        {
            collections = new List<Vehicle>();
        }
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
