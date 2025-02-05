using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment2
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Borrower> Borrowers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        // Method to add a book to the library
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // Method to register a borrower
        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        // Method to borrow a book
        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null && !book.IsBorrowed)
            {
                borrower.BorrowBook(book);
            }
        }

        // Method to return a book
        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null && book.IsBorrowed)
            {
                borrower.ReturnBook(book);
            }
        }

        // Method to view all books
        public List<Book> ViewBooks()
        {
            return Books;
        }

        // Method to view all borrowers
        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }

}
