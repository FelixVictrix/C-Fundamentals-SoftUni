using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            //if (IsLength(password))
            //{
            //    if (IsDigits(password))
            //    {
            //        if (IsCount(password))
            //        {
            //            Console.WriteLine("Password is valid");
            //        }
            //    }
            //}
            IsLength(password);
            IsDigits(password);
            IsCount(password);
            //bool isValid = IsLength(password) && IsDigits(password) && IsCount(password);
            //if (isValid)
            //{
            //    Console.WriteLine("Password is valid");
            //}

        }


        static bool IsLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }

        static bool IsDigits(string password)
        {
            bool isTrue = password.All(c => char.IsLetterOrDigit(c));
            if (isTrue)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
        }

        static bool IsCount(string password)
        {
            int count = 0;
            foreach (var chr in password)
            {
                if (password.All(c => char.IsDigit(chr)))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
        }
    }
}
