using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal partsPriceSum = 0;
            decimal taxesSum = 0;
            decimal totalPrice = 0;

            string input = Console.ReadLine();

            while (input != "special" && input != "regular")
            {
                decimal currPrice = decimal.Parse(input);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                partsPriceSum += currPrice;
                taxesSum += currPrice * (decimal)0.20;
                totalPrice += currPrice * (decimal)1.20;

                input = Console.ReadLine();
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            if (input == "special")
            {
                totalPrice *= (decimal)0.9;
            }
            Console.WriteLine($"Congratulations you've just bought a new computer!\n" +
                              $"Price without taxes: {partsPriceSum:f2}$\n" +
                              $"Taxes: {taxesSum:f2}$\n" +
                              $"-----------\n" +
                              $"Total price: {totalPrice:f2}$");
        }
    }
}
