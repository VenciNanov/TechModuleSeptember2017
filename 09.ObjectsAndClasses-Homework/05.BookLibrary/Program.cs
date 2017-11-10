using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library() { Name = "SomeName", books = GetBooks() };

            PrintResults(library);
        }
         private static void PrintResults(Library library)
        {
            foreach (var books in library.books.GroupBy(x => x.Author).OrderByDescending(x => x.Sum(y => y.Price)).ThenBy(z => z.Key))
            {
                Console.WriteLine($"{books.Key} -> {books.Sum(x => x.Price):f2}");
            }
        }

        public static List<Book> GetBooks()
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                DateTime date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                Book book = new Book() { Title = input[0], Author = input[1], Publisher = input[2], ReleaseDate = date, ISBN = input[4], Price = double.Parse(input[5]) };

                books.Add(book);
            }
            return books;
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> books { get; set; }
    }
}
