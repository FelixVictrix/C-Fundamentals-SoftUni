using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<decimal, int>> products = new Dictionary<string, Dictionary<decimal, int>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] productInfo = input.Split();
                string name = productInfo[0];
                decimal price = decimal.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Dictionary<decimal, int>());
                    products[name].Add(price, quantity);

                }
                else if (products.ContainsKey(name))
                {
                    if (products[name].ContainsKey(price))
                    {
                        products[name][price] += quantity;
                    }
                    else
                    {
                        int oldQuantity = products[name].Select(x => x.Value).FirstOrDefault();
                        int newQuantity = oldQuantity + quantity;
                        products[name] = new Dictionary<decimal, int>();
                        products[name].Add(price, newQuantity);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var kvp in products)
            {
                foreach (var item in kvp.Value)
                {
                    decimal price = item.Key * item.Value;
                    Console.WriteLine($"{kvp.Key} -> {price:f2}");
                }



            }
        }
    }
}
