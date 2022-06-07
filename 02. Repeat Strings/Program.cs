using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] text = Console.ReadLine().Split();
            foreach (var item in text)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item);
                }
            }

        }
    }
}
