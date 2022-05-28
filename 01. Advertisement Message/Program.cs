using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {

            GetRandom phrase = new GetRandom(new List<string>()
            {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
            });
            GetRandom events = new GetRandom(new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            });
            GetRandom autors = new GetRandom(new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            });
            GetRandom cities = new GetRandom(new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            });
            Console.WriteLine($"{phrase.GetrandomPhrase()} {events.GetrandomPhrase()} {autors.GetrandomPhrase()} – {cities.GetrandomPhrase()}.");
        }
    }

    class GetRandom
    {
        public GetRandom(List<string> phrases)
        {
            Phrases = phrases;
        }

        public List<string> Phrases { get; set; }

        public string GetrandomPhrase()
        {
            Random rnd = new Random();
            return Phrases[rnd.Next(Phrases.Count)];
        }
    }

}
