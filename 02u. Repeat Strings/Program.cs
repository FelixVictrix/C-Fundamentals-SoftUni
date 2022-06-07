using System;
using System.Text;

namespace _02u._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();

            foreach (var item in text)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sb.Append(item);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
