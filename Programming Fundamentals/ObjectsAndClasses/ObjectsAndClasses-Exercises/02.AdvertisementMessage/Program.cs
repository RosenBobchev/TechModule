using System;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            for (int i = 0; i <= number; i++)
            {
                string phraseIndex = phrases[rnd.Next(0, phrases.Length)];
                string eventIndex = events[rnd.Next(0, events.Length)];
                string authorIndex = authors[rnd.Next(0, authors.Length)];
                string townIndex = cities[rnd.Next(0, cities.Length)];
                Console.WriteLine($"{phraseIndex} {eventIndex} {authorIndex} – {townIndex}.");
            }
        }
    }
}
