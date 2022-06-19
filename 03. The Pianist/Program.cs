using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                var piece = info[0];
                var composer = info[1];
                var key = info[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new List<string>());
                }
                pieces[piece].Add(composer);
                pieces[piece].Add(key);
            }

            string input = Console.ReadLine();

            
            while (input != "Stop")
            {
                string[] command = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string piece = command[1];

                if (action == "Add")
                {
                    var composer = command[2];
                    var key = command[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, new List<string>());
                        pieces[piece].Add(composer);
                        pieces[piece].Add(key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string isRemoved = pieces.Remove(piece)
                        ? $"Successfully removed {piece}!"
                        : $"Invalid operation! {piece} does not exist in the collection.";
                
                    Console.WriteLine(isRemoved);
                }
                else if (action == "ChangeKey")
                {
                    var key = command[2];
                    if (pieces.ContainsKey(piece))
                    {
                       pieces[piece][1] = key;
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }

                input = Console.ReadLine();
            }
            foreach (var item in pieces)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
