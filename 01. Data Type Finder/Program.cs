using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            int integerValue;
            double floatValue;
            char charValue;
            bool boolValue;
            string stringValue;

            while ((string)input != "END")
            {
                if (int.TryParse(input, out integerValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out floatValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else  
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }

        }
    }
}
