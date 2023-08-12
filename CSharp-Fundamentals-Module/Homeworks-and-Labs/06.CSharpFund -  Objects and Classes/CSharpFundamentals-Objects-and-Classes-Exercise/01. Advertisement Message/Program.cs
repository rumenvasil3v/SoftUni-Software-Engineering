using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makesmiracles. I am happy of the results!",
                "I cannot believe but now I feelawesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            List<Advertisement> advertisements = new List<Advertisement>();
            Random random = new Random();

            int numberOfMessages = int.Parse(Console.ReadLine());
            RandomAdvertisements(numberOfMessages, advertisements, random, phrases, events, authors, cities);

            Advertisement.PrintResult(advertisements);
        }

        static void RandomAdvertisements(int numberOfMessages, List<Advertisement> advertisements, Random random, string[] phrases, string[] events, string[] authors, string[] cities)
        {
            for (int i = 0; i < numberOfMessages; i++)
            {
                int randomPhraseIndex = random.Next(0, phrases.Length);
                int randomEventIndex = random.Next(0, events.Length);
                int randomAuthorIndex = random.Next(0, authors.Length);
                int randomCityIndex = random.Next(0, cities.Length);

                Advertisement advertisement = new Advertisement(phrases[randomPhraseIndex], events[randomEventIndex], authors[randomAuthorIndex], cities[randomCityIndex]);

                advertisements.Add(advertisement);
            }
        }
    }

    public class Advertisement
    {
        public Advertisement(string phrases, string events, string authors, string cities)
        {
            Phrases = phrases;
            Events = events;
            Authors = authors;
            Cities = cities;
        }

        public string Phrases { get; set; }
        
        public string Events { get; set; }

        public string Authors { get; set; }

        public string Cities { get; set; }

        public static void PrintResult(List<Advertisement> advertisements)
        {
            foreach (Advertisement advertisement in advertisements)
            {
                Console.WriteLine($"{advertisement.Phrases} {advertisement.Events} {advertisement.Authors} – {advertisement.Cities}");
            }
        }
    }
}