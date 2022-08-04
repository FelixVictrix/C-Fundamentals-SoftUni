using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {

            string stops = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] command = input
                    .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                string action = command[0];

                if (action == "Add")
                {
                    stops = AddText(stops, command);
                }
                else if (action == "Remove")
                {
                    stops = RemoveText(stops, command);
                }
                else if (action == "Switch")
                {
                    stops = SwitchText(stops, command);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        static string SwitchText(string stops, string[] command)
        {
            string oldString = command[1];
            string newString = command[2];
            stops = stops.Replace(oldString, newString);
            Console.WriteLine(stops);
            return stops;
        }

        static string RemoveText(string stops, string[] command)
        {
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);

            if (startIndex >= 0 && startIndex <= stops.Length - 1 && endIndex >= 0 && endIndex <= stops.Length - 1 && endIndex - startIndex >= 0)
            {
                stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(stops);
                return stops;
            }
            Console.WriteLine(stops);
            return stops;
        }

        static string AddText(string stops, string[] command)
        {

            int index = int.Parse(command[2]);
            string text = command[3];

            if (index >= 0 && index < stops.Length)
            {
                stops = stops.Insert(index, text);
                Console.WriteLine(stops);
                return stops;
            }
            Console.WriteLine(stops);
            return stops;
        }
    }
}
