using System;
using System.Collections.Generic;

namespace _04u._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productInfo = input.Split();
                string name = productInfo[0];
                double price = double.Parse(productInfo[1]);
                double quantity = double.Parse(productInfo[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new double[2]);
                }
                double oldQuantity = products[name][1] + quantity;
                products[name] = new double[] { price, oldQuantity };

                input = Console.ReadLine();
            }
            foreach (var kvp in products)
            {
                double price = kvp.Value[0] * kvp.Value[1];
                Console.WriteLine($"{kvp.Key} -> {price:f2}");
            }
        }
    }
}
