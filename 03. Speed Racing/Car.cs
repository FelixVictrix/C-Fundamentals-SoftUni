//namespace _03._Speed_Racing
//{
//    public class Car
//    {

//        public Car(string model, double fuelAmount, double fuelConsumtion)
//        {
//            Model = model;
//            FuelAmount = fuelAmount;
//            FuelConsumtion = fuelConsumtion;
//        }

//        public string Model { get; set; }
//        public double FuelAmount { get; set; }
//        public double FuelConsumtion { get; set; }
//        public double Distance = 0;

//        public void CanDrive(double distance)
//        {
//            if (this.FuelAmount - (this.FuelConsumtion * distance) > 0)
//            {
//                this.FuelAmount -= this.FuelConsumtion * distance;
//                this.Distance += distance;
//            }
//            else
//            {
//                System.Console.WriteLine("Insufficient fuel for the drive");
//            }
//        }

//    }
//}
