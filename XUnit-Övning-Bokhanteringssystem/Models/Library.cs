using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit_Övning_Bokhanteringssystem.Models
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if(books.Any(B => B.ISBN == book.ISBN))
            {
                throw new InvalidOperationException("A Book With That ISBN aldready exists");
            }
            books.Add(book);
        }

        public bool RemoveBook(string isbn)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if(book != null)
            {
                books.Remove(book);
                return true;
            }
            return false;
        }

        public Book GetBook(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public List<Book> SearchBooks(string keyword)
        {
            return books.Where(b => b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                               b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool UpdateBook(string isbn, string title, string author, int year)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);

            if(book != null)
            {
                book.Title = title;
                book.Author = author;
                book.Year = year;
                return true;
            }
            return false;
        }
    }
}