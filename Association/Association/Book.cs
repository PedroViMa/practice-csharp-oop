using System;
using System.Security.Policy;

namespace Association.Libraries
{
    internal class Book
    {
        protected string ISBN { get; set; }
        protected string Title { get; set; }
        protected string Author { get; set; }

        public Book (string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        public void ShowInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

        public Book GetBook(string isbn)
        {
            return isbn.Equals(ISBN) ? this : null;
        }
    }
}
