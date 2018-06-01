using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Book> booksList = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var inputString = Console.ReadLine().Split(' ');
                booksList.Add(new Book(inputString[0], inputString[1], inputString[2], DateTime.Parse(inputString[3]), long.Parse(inputString[4]), double.Parse(inputString[5])));
            }

            var newLibrary = new Library("newLibrary", booksList);
            var sortedList = newLibrary.books.Select(b => new
            {
                Author = b.author,
                TotalPrice = newLibrary.books.Where(b1 => b1.author.Equals(b.author)).Sum(b1 => b1.price)
            }).Distinct().OrderByDescending(b => b.TotalPrice).ThenBy(b => b.Author).ToList();

            foreach (var book in sortedList)
            {
            Console.WriteLine($"{book.Author} -> {book.TotalPrice:f2}");
            }
        }
    }

    public class Book
    {
        public string title;
        public string author;
        public string publisher;
        public DateTime releaseDate;
        public long ISBN;
        public double price;

        public Book(string t, string a, string p, DateTime d, long i, double pr)
        {
            title = t;
            author = a;
            publisher = p;
            releaseDate = d;
            ISBN = i;
            price = pr;
        }
    }

    public class Library
    {
        public string name;
        public List<Book> books;

        public Library(string n, List<Book> b)
        {
            name = n;
            books = b;
        }
    }
}
