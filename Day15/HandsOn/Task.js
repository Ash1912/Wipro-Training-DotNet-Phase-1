// Implement the TaskManager class
class TaskManager {
    constructor() {
        this.tasks = [];
    }
    addTask(task) {
        this.tasks.push(task);
        console.log(`Task added successfully: ${task.title}`);
        renderTasks(); // Update the UI after adding
    }
    viewTasks() {
        return this.tasks;
    }
    modifyTask(id, updatedTask) {
        const task = this.tasks.find(t => t.id === id);
        if (!task) {
            console.log(`Error: Task with ID ${id} does not exist.`);
            return;
        }
        Object.assign(task, updatedTask);
        console.log(`Task modified successfully: ${task.title}`);
        renderTasks(); // Update the UI after modification
    }
    deleteTask(id) {
        const index = this.tasks.findIndex(t => t.id === id);
        if (index === -1) {
            console.log(`Error: Task with ID ${id} does not exist.`);
            return;
        }
        this.tasks.splice(index, 1);
        console.log(`Task deleted successfully.`);
        renderTasks(); // Update the UI after deletion
    }
}
// Create a global instance of TaskManager
const manager = new TaskManager();
// Function to add a task from HTML input
function addNewTask() {
    const titleInput = document.getElementById("taskTitle");
    const descInput = document.getElementById("taskDesc");
    if (!titleInput.value || !descInput.value) {
        alert("Please enter a task title and description.");
        return;
    }
    const newTask = {
        id: Date.now(), // Generate unique ID
        title: titleInput.value,
        description: descInput.value,
        completed: false,
    };
    manager.addTask(newTask);
    // Clear input fields
    titleInput.value = "";
    descInput.value = "";
}
// Function to delete a task from HTML
function deleteTask(id) {
    manager.deleteTask(id);
}
// Function to render tasks in the HTML
function renderTasks() {
    const taskList = document.getElementById("taskList");
    taskList.innerHTML = ""; // Clear existing list
    manager.viewTasks().forEach(task => {
        const li = document.createElement("li");
        li.innerHTML = `
            ${task.title} - ${task.description} 
            <button onclick="deleteTask(${task.id})">Delete</button>
        `;
        taskList.appendChild(li);
    });
}
// Attach functions to window for HTML access
window.addNewTask = addNewTask;
window.deleteTask = deleteTask;
//In order to window - use the command - tsc task.ts --target es6
// Testing the TaskManager class
const manager1 = new TaskManager();
// Adding tasks
manager1.addTask({ id: 1, title: "Complete Assignment", description: "Finish TypeScript assignment", completed: false });
manager1.addTask({ id: 2, title: "Read Book", description: "Read 20 pages of a book", completed: false });
// Viewing tasks
console.log("Tasks:", manager1.viewTasks());
// Modifying a task
manager1.modifyTask(1, { completed: true });
// Deleting a task
manager1.deleteTask(2);
// Attempting to delete a non-existent task
manager1.deleteTask(3);
