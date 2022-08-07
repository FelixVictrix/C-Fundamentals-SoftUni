using System;

namespace Decrypting_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];

                if (action == "Replace")
                {
                    var currChar = command[1];
                    var newChar = command[2];
                    text = text.Replace(currChar, newChar);
                    Console.WriteLine(text);
                }
                else if (action == "Cut")
                {
                    var startIndex = int.Parse(command[1]);
                    var endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && endIndex >= 0 && startIndex < text.Length && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices");
                    }
                }
                else if (action == "Make")
                {
                    var @case = command[1];

                    if (@case == "Upper")
                    {
                        text = text.ToUpper();
                    }
                    else
                    {
                        text = text.ToLower();
                    }
                    Console.WriteLine(text);
                }
                else if (action == "Check")
                {
                    var message = command[1];
                    if (text.Contains(message))
                    {
                        Console.WriteLine($"Message contains {message}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {message}");
                    }
                }
                else if (action == "Sum")
                {
                    var startIndex = int.Parse(command[1]);
                    var endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && endIndex >= 0 && startIndex < text.Length && endIndex < text.Length)
                    {
                        int sum = 0;
                        string toSum = text.Substring(startIndex, endIndex - startIndex + 1);
                        foreach (var item in toSum)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
