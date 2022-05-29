using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            string input = Console.ReadLine();

            while (input != "End")
            {

                string[] vehicleInfo = input.Split();

                string typeOfVehicle = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsepowerOfVehicle = int.Parse(vehicleInfo[3]);

                if (typeOfVehicle == "car")
                {
                    typeOfVehicle = "Car";
                }
                else
                {
                    typeOfVehicle = "Truck";
                }

                vehicles.Add(new Vehicle(typeOfVehicle, model, color, horsepowerOfVehicle));

                input = Console.ReadLine();
            }

            string inputType = Console.ReadLine();

            while (inputType != "Close the Catalogue")
            {
                foreach (Vehicle v in vehicles.Where(x => x.Model == inputType))
                {
                    Console.WriteLine(v.ToString());
                }
                inputType = Console.ReadLine();
            }

            AverageHP(vehicles);
            //"

            // Console.WriteLine(carHpSum);
        }

        static void AverageHP(List<Vehicle> vehicles)
        {
            double carHpSum = vehicles.Where(x => x.Type == "Car").Sum(x => x.HorsePower);
            double truckHpSum = vehicles.Where(x => x.Type == "Truck").Sum(x => x.HorsePower);

            int carCount = 0;
            int truckCount = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Type == "Car")
                {
                    carCount++;
                }
                else
                {
                    truckCount++;
                }
            }
            double carAverage = 0;
            double truckAverage = 0;
            if (carCount>0)
            { 
                carAverage = carHpSum / carCount;
            }
            if (truckCount>0)
            {
                truckAverage = truckHpSum / truckCount;
            }
            
            

            Console.WriteLine($"Cars have average horsepower of: {carAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverage:f2}.");
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {

            return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";

        }
    }

}
