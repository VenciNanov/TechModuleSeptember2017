using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrase =
            {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                string rndPhrase = phrase[rand.Next(0, phrase.Length)];
                string rndEvent = events[rand.Next(0, events.Length)];
                string rndAuthor = authors[rand.Next(0, authors.Length)];
                string rndCity = city[rand.Next(0, city.Length)];

                Console.WriteLine("{0} {1} {2} - {3}", rndPhrase, rndEvent, rndAuthor, rndCity);
            }
        }

    }
}