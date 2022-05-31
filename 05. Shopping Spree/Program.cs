using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleInfo = Console.ReadLine()
                     .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < peopleInfo.Length - 1; i += 2)
            {
                people.Add(new Person
                {
                    Name = peopleInfo[i],
                    Money = decimal.Parse(peopleInfo[i + 1])
                });
            }

            string[] productInfo = Console.ReadLine()
                    .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < productInfo.Length - 1; i += 2)
            {
                products.Add(new Product
                {
                    Name = productInfo[i],
                    Cost = decimal.Parse(productInfo[i + 1])
                });
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split();
                string name = command[0];
                string product = command[1];

                Person person = people.FirstOrDefault(p => p.Name == name);
                Product product1 = products.FirstOrDefault(p => p.Name == product);

                if (person.Money >= product1.Cost)
                {
                    person.BagOfProducts.Add(product1);
                    person.Money -= product1.Cost;
                    Console.WriteLine($"{person.Name} bought {product}");

                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product}");
                }



                input = Console.ReadLine();
            }
            foreach (var item in people)
            {
                if (item.BagOfProducts.Any())
                {
                    Console.Write($"{item.Name} - ");
                    string[] names = item.BagOfProducts.Select(x => x.Name).ToArray();
                    Console.Write(string.Join(", ", names));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                
            }
        }
    }
    class Person
    {
        public Person()
        {
            BagOfProducts = new List<Product>();
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
