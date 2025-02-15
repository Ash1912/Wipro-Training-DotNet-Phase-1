import "./App.css";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import FuncCounter from "./FuncCounter";
import { Employee } from "./Employee";
import ListImages from "./ListImages";
import { BookList } from "./BookList";
import { TodoApp } from "./TodoApp";
import Navbar from "./Navbar"; // Navigation Bar Component

function App() {
  return (
    <Router>
      <Navbar />
      <div className="container mt-4">
        <Routes>
          <Route path="/" element={<FuncCounter />} />
          <Route path="/employee" element={<Employee name="Wipro" />} />
          <Route path="/list-images" element={<ListImages />} />
          <Route path="/book-list" element={<BookList />} />
          <Route path="/todo-app" element={<TodoApp />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
