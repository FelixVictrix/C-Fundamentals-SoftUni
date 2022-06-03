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




                input = Console.ReadLine();
            }
        }
    }
}
