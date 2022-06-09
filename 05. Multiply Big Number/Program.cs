using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNUm = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int numLeft = 0;

            if (multiplier == 0 || bigNUm == "0")
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = bigNUm.Length - 1; i >= 0; i--)
            {

                int curr = int.Parse(bigNUm[i].ToString());
                int multiply = curr * multiplier + numLeft;

                int numToAdd = multiply % 10;
                numLeft = multiply / 10;

                sb.Insert(0, numToAdd);

            }
            if (numLeft > 0)
            {
                sb.Insert(0, numLeft);
            }
            Console.WriteLine(sb);
        }
    }
}