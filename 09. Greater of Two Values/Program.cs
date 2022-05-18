using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputType = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (inputType)
            {
                case "int":
                    int firstInt = int.Parse(firstValue);
                    int secondInt = int.Parse(secondValue);
                    Console.WriteLine(Graeter(firstInt, secondInt));
                    break;
                case "char":
                    char firstChar = char.Parse(firstValue);
                    char secondChar = char.Parse(secondValue);
                    Console.WriteLine(Graeter(firstChar, secondChar));
                    break;
                case "string":
                    Console.WriteLine(Graeter(firstValue, secondValue));
                    break;
            }



        }

        static string Graeter(string firstStr, string secondStr)
        {
            int result = firstStr.CompareTo(secondStr);
            if (result > 0)
            {
                return firstStr;
            }
            else
            {
                return secondStr;
            }
        }

        static int Graeter(int firstInt, int secondInt)
        {
            int result = firstInt.CompareTo(secondInt);
            if (result > 0)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }
        static char Graeter(char firstChar, char secondChar)
        {
            int result = firstChar.CompareTo(secondChar);
            if (result > 0)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
    }
}
