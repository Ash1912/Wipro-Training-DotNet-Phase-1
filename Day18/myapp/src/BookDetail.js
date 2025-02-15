import React from "react";

const BookItem = ({ item, index, showDetails, toggleDetails }) => {
  return (
    <div className="border p-3 mb-2">
      <h3>{item.title}</h3>
      {showDetails && (
        <>
          <p>Author: {item.author}</p>
          <p>Genre: {item.genre}</p>
        </>
      )}
      <button className="btn btn-info" onClick={() => toggleDetails(index)}>
        {showDetails ? "Hide Details" : "Show Details"}
      </button>
    </div>
  );
};

export default BookItem;
