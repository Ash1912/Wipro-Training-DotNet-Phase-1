const express = require("express");
const cors = require("cors");
const bodyParser = require("body-parser");

const app = express();
const PORT = 5000;

app.use(cors());
app.use(bodyParser.json());

// Sample Books Data
let books = [
    { id: 1, title: "The Alchemist", author: "Paulo Coelho" },
    { id: 2, title: "Atomic Habits", author: "James Clear" },
    { id: 3, title: "The Great Gatsby", author: "F. Scott Fitzgerald" },
    { id: 4, title: "To Kill a Mockingbird", author: "Harper Lee" }
];

// 📌 1️⃣ GET - Fetch all books
app.get('/books', (req, res) => {
    res.json(books);
});

// 📌 2️⃣ POST - Add a new book
app.post('/books', (req, res) => {
    const { title, author } = req.body;
    if (!title || !author) {
        return res.status(400).json({ message: "Title and author are required" });
    }
    const newBook = { id: books.length + 1, title, author };
    books.push(newBook);
    res.status(201).json(newBook);
});

// 📌 3️⃣ PUT - Update a book
app.put('/books/:id', (req, res) => {
    const bookId = parseInt(req.params.id);
    const bookIndex = books.findIndex(b => b.id === bookId);

    if (bookIndex !== -1) {
        books[bookIndex] = { id: bookId, ...req.body };
        res.json(books[bookIndex]);
    } else {
        res.status(404).json({ message: "Book not found" });
    }
});

// 📌 4️⃣ DELETE - Remove a book
app.delete("/books/:id", (req, res) => {
    const bookId = parseInt(req.params.id);
    books = books.filter(book => book.id !== bookId);
    res.json({ message: "Book deleted successfully" });
});

// Start the Server
app.listen(PORT, () => {
    console.log(`📡 Server running on http://localhost:${PORT}/`);
});
