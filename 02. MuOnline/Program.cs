using System;
using System.Collections.Generic;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> rooms = new List<string>(Console.ReadLine().Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries));

            int health = 100;
            int coins = 0;
            int room = 0;

            for (int i = 0; i < rooms.Count - 1; i += 2)
            {
                room++;
                string command = rooms[i];
                int value = int.Parse(rooms[i + 1]);

                if (command == "potion")
                {
                    int healed = 0;
                    if (health + value > 100)
                    {
                        healed = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += value;
                        healed = value;
                    }

                    Console.WriteLine($"You healed for {healed} hp.");
                    Console.WriteLine($"Current health: {health} hp.");

                }
                else if (command == "chest")
                {
                    coins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else
                {
                    if (health > value)
                    {
                        health -= value;
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {room}");
                        return;
                    }
                }

            }
            Console.WriteLine($"You've made it!\nBitcoins: {coins}\nHealth: {health}");
        }
    }
}
