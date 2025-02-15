import { Link } from "react-router-dom";
import { Navbar, Nav, Container } from "react-bootstrap";
import "./styles/navbar.css";

export default function NavigationBar() {
  return (
    <Navbar className="custom-navbar" expand="lg">
      <Container>
        <Navbar.Brand className="brand">📚 React Project</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="ms-auto">
            <Nav.Link as={Link} to="/" className="nav-link">Counter</Nav.Link>
            <Nav.Link as={Link} to="/employee" className="nav-link">Employee</Nav.Link>
            <Nav.Link as={Link} to="/list-images" className="nav-link">List Images</Nav.Link>
            <Nav.Link as={Link} to="/book-list" className="nav-link">Book List</Nav.Link>
            <Nav.Link as={Link} to="/todo-app" className="nav-link">Todo App</Nav.Link>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
}
