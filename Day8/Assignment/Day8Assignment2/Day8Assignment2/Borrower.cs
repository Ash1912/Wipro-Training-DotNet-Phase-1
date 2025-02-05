using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment2
{
    public class Borrower
    {
        public string Name { get; set; }
        public string LibraryCardNumber { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Borrower(string name, string libraryCardNumber)
        {
            Name = name;
            LibraryCardNumber = libraryCardNumber;
            BorrowedBooks = new List<Book>();
        }

        // Method to borrow a book
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
            book.Borrow();
        }

        // Method to return a book
        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
            book.Return();
        }
    }

}
