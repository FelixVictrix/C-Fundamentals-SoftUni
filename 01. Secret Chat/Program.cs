using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] input = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string action = input[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(input[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (action == "Reverse")
                {
                    string subString = input[1];
                    if (message.Contains(subString))
                    {
                        int index = message.IndexOf(subString);
                        message = message.Remove(index, subString.Length);
                        var reverse = subString.Reverse().ToArray();
                        message = message + new string(reverse);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = input[1];
                    string replacment = input[2];
                    message = message.Replace(substring, replacment);
                    Console.WriteLine(message);

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
