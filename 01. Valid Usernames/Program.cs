using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] userNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);



            foreach (var user in userNames)
            {
                if (user.Length < 3 || user.Length > 16)
                {
                    continue;
                }

                bool isReal = false;

                foreach (var chr in user)
                {
                    if (!(char.IsDigit(chr) || char.IsLetter(chr) || chr == '_' || chr == '-'))
                    {
                        isReal = false;
                        break;
                    }
                    isReal = true;
                }
                if (isReal)
                {
                    Console.WriteLine(user);
                }
            }

        }
    }
}
