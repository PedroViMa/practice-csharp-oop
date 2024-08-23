using Association.Libraries;
using System;

namespace Association
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("ISBN1", "Titulo", "Pepe"));
            library.AddBook(new Book("ISBN2", "Titulo", "Pepe"));
            library.AddBook(new Book("ISBN3", "Titulo", "Pepe"));

            library.ListBooks();
            Console.WriteLine();

            Console.WriteLine("Enter the ISBN of the book to be removed:");
            string isbnToRemove = Console.ReadLine();
            Console.WriteLine(library.RemoveBook(isbnToRemove));

            Console.WriteLine();
            library.ListBooks();

        }
    }
}
