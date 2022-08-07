using System;

namespace _01._Decrypting_Commands
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
                    text = Replace(text, command);
                  
                }
                else if (action == "Cut")
                {
                    text = Cut(text, command);
                   
                }
                else if (action == "Make")
                {
                    text = Make(text, command);
                   
                }
                else if (action == "Check")
                {
                    Check(text, command);
                }
                else if (action == "Sum")
                {
                    Sum(text, command);
                }


                input = Console.ReadLine();
            }

        }

        static void Sum(string text, string[] command)
        {
            var startIndex = int.Parse(command[1]);
            var endIndex = int.Parse(command[2]);

            if (startIndex >= 0 && endIndex >= 0 && startIndex < text.Length  && endIndex < text.Length && endIndex - startIndex > 0)
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
                Console.WriteLine("Invalid indices!");
            }

        }

        static string Make(string text, string[] command)
        {
            var @case = command[1];
            switch (@case)
            {
                case "Upper":
                    text = text.ToUpper();
                    break;
                case "Lower":
                    text = text.ToLower();
                    break;
            }
            Console.WriteLine(text);
            return text;
        }

        static void Check(string text, string[] command)
        {
            var subString = command[1];
            if (text.Contains(subString))
            {
                Console.WriteLine($"Message contains {subString}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {subString}");
            }
        }

        static string Cut(string text, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endtIndex = int.Parse(command[2]);

            if (startIndex >= 0 && startIndex < text.Length  && endtIndex > 0 && endtIndex < text.Length)
            {
                text = text.Remove(startIndex, endtIndex - startIndex + 1);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Invalid indices!");
            }

            return text;
        }

        static string Replace(string text, string[] command)
        {
            string currentChar = command[1];
            string newChar = command[2];
            text = text.Replace(currentChar, newChar);
            Console.WriteLine(text);
            return text;
        }
    }
}
