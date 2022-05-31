using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsNum = int.Parse(Console.ReadLine());

            List<Car> listCars = new List<Car>();

            for (int i = 0; i < carsNum; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);
 
                listCars.Add(new Car(model, fuelAmount, fuelConsumptionFor1km));

            }

            string input = Console.ReadLine();

            while (input != "End")
            {

                string[] command = input.Split();
                string action = command[0];
                string model = command[1];
                double distance = double.Parse(command[2]);

                    Car car = listCars.FirstOrDefault(x => x.Model == model);
                    car.CanDrive(distance);

                input = Console.ReadLine();
            }

            foreach (var item in listCars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.Distance}");
            }
        }
    }
    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumtion)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumtion = fuelConsumtion;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumtion { get; set; }
        public double Distance = 0;

        public void CanDrive(double distance)
        {
            if (this.FuelAmount - (this.FuelConsumtion * distance) >= 0)
            {
                this.FuelAmount -= this.FuelConsumtion * distance;
                this.Distance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }

}
