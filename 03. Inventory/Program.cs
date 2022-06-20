using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listOfItems = new List<string>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] command = input
                    .Split(new string[] { " - ", ":" }, StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];
                string item = command[1];

                if (action == "Collect" && !listOfItems.Contains(item))
                {
                    listOfItems.Add(item);
                }
                else if (action == "Drop" && listOfItems.Contains(item))
                {
                    listOfItems.Remove(item);
                }
                else if (action == "Combine Items" && listOfItems.Contains(item))
                {
                    string newItem = command[2];
                    int index = listOfItems.IndexOf(item);
                    listOfItems.Insert(index + 1, newItem);
                }
                else if (action == "Renew" && listOfItems.Contains(item))
                {
                    string moving = item;
                    listOfItems.Remove(item);
                    listOfItems.Add(moving);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", listOfItems));
        }
    }
}
