using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<int>> listOfCities = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] cityInfo = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string name = cityInfo[0];
                int population = int.Parse(cityInfo[1]);
                int gold = int.Parse(cityInfo[2]);

                if (!listOfCities.ContainsKey(name))
                {
                    listOfCities.Add(name, new List<int>() { 0, 0 });
                }
                listOfCities[name][0] += population;
                listOfCities[name][1] += gold;

                input = Console.ReadLine();
            }

            string action = Console.ReadLine();

            while (action != "End")
            {
                string[] command = action.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string events = command[0];
                var town = command[1];

                if (events == "Plunder")
                {
                    var people = int.Parse(command[2]);
                    var gold = int.Parse(command[3]);

                    if (listOfCities.ContainsKey(town))
                    {
                        listOfCities[town][0] -= people;
                        listOfCities[town][1] -= gold;

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    }

                    if (listOfCities[town][0] <= 0 || listOfCities[town][1] <= 0)
                    {
                        listOfCities.Remove(town);

                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (events == "Prosper")
                {
                    var gold = int.Parse(command[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        listOfCities[town][1] += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {listOfCities[town][1]} gold.");
                    }

                }


                action = Console.ReadLine();
            }

            if (listOfCities.Any())
            {
                Console.WriteLine($"Ahoy, Captain! There are {listOfCities.Count} wealthy settlements to go to:");

                foreach (var item in listOfCities)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

    }
}
