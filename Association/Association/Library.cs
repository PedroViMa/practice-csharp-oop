using System;
using System.Collections.Generic;

namespace Association.Libraries
{
    internal class Library
    {
        private readonly List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public Library(List<Book> books)
        {
            this.books = books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public string RemoveBook(string isbn)
        {
            foreach (Book book in books)
            {
                if (book.GetBook(isbn) != null)
                {
                    books.Remove(book);
                    return $"Successfully removed book {isbn}.";
                }
            }

            return $"Book {isbn} does not exist.";
        }

        public void ListBooks()
        {
            foreach (Book book in books)
            {
                book.ShowInfo();
            }
        }

    }
}
