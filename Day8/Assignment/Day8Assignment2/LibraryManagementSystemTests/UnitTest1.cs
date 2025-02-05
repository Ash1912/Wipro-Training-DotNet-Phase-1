using Day8Assignment2;

namespace LibraryManagementSystemTests
{
    public class LibraryTests
    {
        private Library _library;
        private Book _book;
        private Borrower _borrower;

        [SetUp]
        public void Setup()
        {
            _library = new Library();
            _book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "1234567890");
            _borrower = new Borrower("John Doe", "B123");
            _library.AddBook(_book);
            _library.RegisterBorrower(_borrower);
        }

        [Test]
        public void AddBook_ShouldAddBookToLibrary()
        {
            Assert.AreEqual(1, _library.ViewBooks().Count);
        }

        [Test]
        public void RegisterBorrower_ShouldAddBorrowerToLibrary()
        {
            Assert.AreEqual(1, _library.ViewBorrowers().Count);
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed()
        {
            _library.BorrowBook("1234567890", "B123");

            var book = _library.ViewBooks().FirstOrDefault(b => b.ISBN == "1234567890");
            Assert.IsTrue(book.IsBorrowed);
        }

        [Test]
        public void BorrowBook_ShouldAssociateBookWithBorrower()
        {
            _library.BorrowBook("1234567890", "B123");

            var borrower = _library.ViewBorrowers().FirstOrDefault(b => b.LibraryCardNumber == "B123");
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ReturnBook_ShouldMarkBookAsAvailable()
        {
            _library.BorrowBook("1234567890", "B123");
            _library.ReturnBook("1234567890", "B123");

            var book = _library.ViewBooks().FirstOrDefault(b => b.ISBN == "1234567890");
            Assert.IsFalse(book.IsBorrowed);
        }

        [Test]
        public void ReturnBook_ShouldRemoveBookFromBorrower()
        {
            _library.BorrowBook("1234567890", "B123");
            _library.ReturnBook("1234567890", "B123");

            var borrower = _library.ViewBorrowers().FirstOrDefault(b => b.LibraryCardNumber == "B123");
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ViewBooks_ShouldReturnAllBooks()
        {
            var books = _library.ViewBooks();
            Assert.AreEqual(1, books.Count);
        }

        [Test]
        public void ViewBorrowers_ShouldReturnAllBorrowers()
        {
            var borrowers = _library.ViewBorrowers();
            Assert.AreEqual(1, borrowers.Count);
        }
    }
}