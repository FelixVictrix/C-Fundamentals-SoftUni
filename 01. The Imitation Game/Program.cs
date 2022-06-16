using System;
using System.Collections.Generic;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> test = new List<string>(Console.ReadLine().Split());
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder(text);

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] action = input.Split("|");

                string command = action[0];

                if (command == "Move")
                {
                    int count = int.Parse(action[1]);
                    string moving = text.Substring(0, count);
                    text = text.Remove(0, count);
                    text = text + moving;

                }
                else if (command == "Insert")
                {
                    int index = int.Parse(action[1]);
                    string value = action[2];

                    text = text.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = action[1];
                    string replacement = action[2];
                    text = text.Replace(substring, replacement);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {text}");
        }
    }
}
