using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            TotalPrice(product, quantity);
        }

        static void TotalPrice(string product, double quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.50; break;
                case "water":
                    price = 1.00; break;
                case "coke":
                    price = 1.40; break;
                case "snacks":
                    price = 2.00; break;
            }
            double total = quantity*price;
            Console.WriteLine($"{total:f2}");
        }
    }
}
