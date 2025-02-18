import React, { useReducer, useState } from "react";
import "./TaskList.css";

const initialState = [];

const taskReducer = (state, action) => {
  switch (action.type) {
    case "ADD_TASK":
      return [...state, { id: Date.now(), text: action.payload, completed: false }];
    case "TOGGLE_TASK":
      return state.map((task) =>
        task.id === action.payload ? { ...task, completed: !task.completed } : task
      );
    case "EDIT_TASK":
      return state.map((task) =>
        task.id === action.payload.id ? { ...task, text: action.payload.text } : task
      );
    case "DELETE_TASK":
      return state.filter((task) => task.id !== action.payload);
    default:
      return state;
  }
};

const TaskList = () => {
  const [state, dispatch] = useReducer(taskReducer, initialState);
  const [taskText, setTaskText] = useState("");
  const [editId, setEditId] = useState(null);

  const handleSubmit = (e) => {
    e.preventDefault();
    if (editId) {
      dispatch({ type: "EDIT_TASK", payload: { id: editId, text: taskText } });
      setEditId(null);
    } else {
      dispatch({ type: "ADD_TASK", payload: taskText });
    }
    setTaskText("");
  };

  return (
    <div className="task-container">
      <h2 className="title">Task List</h2>
      <form onSubmit={handleSubmit} className="task-form">
        <input
          type="text"
          value={taskText}
          onChange={(e) => setTaskText(e.target.value)}
          placeholder="Enter task"
          required
          className="task-input"
        />
        <button type="submit" className="task-button">{editId ? "Update" : "Add"} Task</button>
      </form>
      <ul className="task-list">
        {state.map((task) => (
          <li key={task.id} className={`task-item ${task.completed ? "completed" : ""}`}>
            {task.text}
            <div className="task-actions">
              <button onClick={() => dispatch({ type: "TOGGLE_TASK", payload: task.id })} className="toggle-button">
                {task.completed ? "Undo" : "Complete"}
              </button>
              <button onClick={() => { setTaskText(task.text); setEditId(task.id); }} className="edit-button">
                Edit
              </button>
              <button onClick={() => dispatch({ type: "DELETE_TASK", payload: task.id })} className="delete-button">
                Delete
              </button>
            </div>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default TaskList;
