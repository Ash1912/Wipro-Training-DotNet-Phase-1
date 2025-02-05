using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Assignment2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
        }

        // Method to mark the book as borrowed
        public void Borrow()
        {
            IsBorrowed = true;
        }

        // Method to mark the book as returned
        public void Return()
        {
            IsBorrowed = false;
        }
    }

}
