using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            int indexOfWord = text.IndexOf(word);

            while (indexOfWord >= 0)
            {

                

                text = text.Remove(indexOfWord,word.Length);
                indexOfWord = text.IndexOf(word);
            }
            Console.WriteLine(text);
        }
    }
}
