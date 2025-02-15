import Book from "./Book";
import React, { useState } from "react";
import BookItem from "./BookDetail";
import "./styles/booklist.css";

export const BookList = () => {
  const [lstbooks] = useState([
    new Book("Book1", "Author1", "Horror"),
    new Book("Book2", "Author2", "Comics"),
    new Book("Book3", "Author3", "Technology"),
  ]);

  const [showDetails, setShowDetails] = useState(Array(lstbooks.length).fill(false));

  const toggleDetails = (index) => {
    const updatedDetails = [...showDetails];
    updatedDetails[index] = !updatedDetails[index];
    setShowDetails(updatedDetails);
  };

  return (
    <div>
      <h1>Book List</h1>
      {lstbooks.map((item, index) => (
        <BookItem key={index} item={item} index={index} showDetails={showDetails[index]} toggleDetails={toggleDetails} />
      ))}
    </div>
  );
};
