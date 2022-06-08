using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string text = Console.ReadLine();

            StringBuilder isDigit = new StringBuilder();
            StringBuilder isLetter = new StringBuilder();
            StringBuilder isElse = new StringBuilder();

            foreach (var item in text)
            {

                if (char.IsDigit(item))
                {
                    isDigit.Append(item);
                   
                }
                else if (char.IsLetter(item))
                {
                    isLetter.Append(item);

                }
               else
                {
                    isElse.Append(item);

                }
            }
            Console.WriteLine(isDigit);
            Console.WriteLine(isLetter);
            Console.WriteLine(isElse);
        }
    }
}
