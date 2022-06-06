using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> register = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                ParkingReg(register, input);
            }

            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }

        private static void ParkingReg(Dictionary<string, string> register, string[] input)
        {
            string command = input[0];
            string username = input[1];

            if (command == "register")
            {
                string licensePlateNumber = input[2];

                if (!register.ContainsKey(username))
                {
                    register.Add(username, licensePlateNumber);
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                }
                else if (register.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                }
            }
            else if (command == "unregister")
            {
                if (register.ContainsKey(username))
                {
                    register.Remove(username);
                    Console.WriteLine($"{ username} unregistered successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
            }

        }
    }
}
