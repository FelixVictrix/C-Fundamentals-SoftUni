using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder(text);

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] command = input.Split();
                string action = command[0];

                if (action == "TakeOdd")
                {
                    string newText = null;

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            newText += text[i].ToString();
                        }
                    }
                    text = newText;
                    Console.WriteLine(text);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(command[1]);
                    int count = int.Parse(command[2]);

                    text = text.Remove(index, count);
                    Console.WriteLine(text);
                }
                else if (action == "Substitute")
                {
                    string substring = command[1];
                    string substitute = command[2];

                    if (text.Contains(substring))
                    {
                        text = text.Replace(substring, substitute);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {text}");
        }
    }
}
