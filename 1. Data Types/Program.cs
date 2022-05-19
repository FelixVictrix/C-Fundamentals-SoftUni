using System;

namespace _1._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            string value = Console.ReadLine();
            GetTypeOfValue(type, value);



        }

        static void GetTypeOfValue(string type, string value)
        {
            switch (type)
            {
                case "int":
                    int valueInt = int.Parse(value);
                    DataTypeMultiplier(valueInt);
                    break;
                case "real":
                    double valueReal = double.Parse(value);
                    DataTypeMultiplier(valueReal);
                    break;
                default:
                    DataTypeMultiplier(value);
                    break;
            }
        }

        static void DataTypeMultiplier(string input)
        {
            Console.WriteLine($"${input}$");
        }

        static void DataTypeMultiplier(int input)
        {
            int multiply = input * 2;
            Console.WriteLine(multiply);
        }
        static void DataTypeMultiplier(double input)
        {
            double multiply = input * 1.5;
            Console.WriteLine($"{multiply:f2}");
        }
    }
}
