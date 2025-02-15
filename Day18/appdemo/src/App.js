import "./App.css";
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import FuncCounter from "./FuncCounter";
import { Employee } from "./Employee";
import ListImages from "./ListImgs";
import { BookList } from "./BookList"; // Import BookList
import { TodoApp } from "./TodoApp"; // Import TodoApp

function App() {
  return (
    <Router>
      <nav>
        <Link to="/">Counter using UseState Hook</Link> |{" "}
        <Link to="/Employee">Employee</Link> |{" "}
        <Link to="/list-images">List Images</Link> |{" "}
        <Link to="/book-list">Book List</Link> |{" "}
        <Link to="/todo-app">Todo App</Link>
      </nav>
      <Routes>
        <Route path="/" element={<FuncCounter />} />
        <Route path="/Employee" element={<Employee name="Wipro" />} />
        <Route path="/list-images" element={<ListImages />} />
        <Route path="/book-list" element={<BookList />} /> {/* Added BookList Route */}
        <Route path="/todo-app" element={<TodoApp />} /> {/* Added TodoApp Route */}
      </Routes>
    </Router>
  );
}

export default App;
