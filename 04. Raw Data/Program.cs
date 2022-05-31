using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Car car = new Car();
                car.Model = model;
                car.Engine.Speed = engineSpeed;
                car.Engine.Power = enginePower;
                car.Cargo.Weight = cargoWeight;
                car.Cargo.Type = cargoType;
                cars.Add(car);

            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var item in cars.Where(c => c.Cargo.Type == command && c.Cargo.Weight < 1000))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var item in cars.Where(c => c.Cargo.Type == command && c.Engine.Power > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }

        }
    }
    class Cargo
    {


        public int Weight { get; set; }
        public string Type { get; set; }
    }
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }
    class Car
    {
        public Car()
        {
            Engine = new Engine();
            Cargo = new Cargo();
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
}
