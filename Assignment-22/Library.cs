using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22
{
    internal class Librarycs : Book
    {
        List<Book> librarycs = new List<Book>();
        public void AddBook(int id, string name, string author, string genre, bool available)
        {
            Book newBook = new Book()
            {
                BookId = id,
                Title = name,
                Author = author,
                Genre = genre,
                IsAvailable = available,
            };
            librarycs.Add(newBook);

        }
        public void PrintAllBooks()
        {
            foreach (var book in librarycs)
            {
                Console.WriteLine("Book Id: " + book.BookId);
                Console.WriteLine("Title of the Book: " + book.Title);
                Console.WriteLine("Author of the Book: " + book.Author);
                Console.WriteLine("Genre of the Book: " + book.Genre);
                Console.WriteLine("Is Book available for borrowing: " + book.IsAvailable);
            }
        }

        public void SearchById(int id)
        {
            Book matchingbook = librarycs.Find(book => book.BookId == id);
            if (matchingbook != null)
            {

                Console.WriteLine("Book Id: " + matchingbook.BookId);
                Console.WriteLine("Title of the Book: " + matchingbook.Title);
                Console.WriteLine("Author of the Book: " + matchingbook.Author);
                Console.WriteLine("Genre of the Book: " + matchingbook.Genre);
                Console.WriteLine("Is Book available for borrowing: " + matchingbook.IsAvailable);
            }
            else
            {
                Console.WriteLine("Id does not exist");
            }
        }

        public void SearchByTitle(string name)
        {
            Book matchingbook = librarycs.Find(book => book.Title == name);
            if (matchingbook != null)
            {
                Console.WriteLine("Book Id: " + matchingbook.BookId);
                Console.WriteLine("Title of the Book: " + matchingbook.Title);
                Console.WriteLine("Author of the Book: " + matchingbook.Author);
                Console.WriteLine("Genre of the Book: " + matchingbook.Genre);
                Console.WriteLine("Is Book available for borrowing: " + matchingbook.IsAvailable);
            }
            else
            {
                Console.WriteLine("Title does not exist");
            }
        }


    }
}