import { Component } from "react";
import { Container, Form, Button, ListGroup } from "react-bootstrap";
import "./styles/todoapp.css";

export class TodoApp extends Component {
  state = { tasks: [], task: "" };

  addTask = () => {
    if (this.state.task.trim() === "") return;
    this.setState((prev) => ({
      tasks: [...prev.tasks, { id: Date.now(), text: prev.task }],
      task: "",
    }));
  };

  removeTask = (id) => {
    this.setState((prev) => ({
      tasks: prev.tasks.filter((task) => task.id !== id),
    }));
  };

  render() {
    return (
      <Container className="mt-4 todo-container">
        <h2 className="text-center">📋 Todo List</h2>
        <Form className="d-flex">
          <Form.Control
            type="text"
            value={this.state.task}
            onChange={(e) => this.setState({ task: e.target.value })}
            placeholder="Enter a task..."
            className="custom-input"
          />
          <Button onClick={this.addTask} variant="success" className="ms-2 custom-btn">
            Add
          </Button>
        </Form>
        <ListGroup className="mt-3 todo-list">
          {this.state.tasks.map((task) => (
            <ListGroup.Item key={task.id} className="todo-item">
              {task.text}
              <Button variant="danger" onClick={() => this.removeTask(task.id)}>
                ❌
              </Button>
            </ListGroup.Item>
          ))}
        </ListGroup>
      </Container>
    );
  }
}
