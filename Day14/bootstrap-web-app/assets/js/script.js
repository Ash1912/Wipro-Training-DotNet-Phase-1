document.addEventListener("DOMContentLoaded", function () {
    console.log("Bootstrap Web App Loaded!");

    // Form Submission Event (Add user details to list)
    document.getElementById("contactForm").addEventListener("submit", function (event) {
        event.preventDefault();

        let name = document.getElementById("nameInput").value.trim();
        let email = document.getElementById("emailInput").value.trim();

        if (name !== "" && email !== "") {
            let tableBody = document.getElementById("userTableBody");
            let newRow = tableBody.insertRow();
            newRow.innerHTML = `<td>${tableBody.rows.length + 1}</td><td>${name}</td><td>${email}</td>`;

            // Show success modal
            let successModal = new bootstrap.Modal(document.getElementById('successModal'));
            successModal.show();

            // Scroll to the User List section
            let userListSection = document.querySelector("userList");  // This is the Users List title section
            userListSection.scrollIntoView({ behavior: "smooth" });

            // Reset the form
            document.getElementById("contactForm").reset();
        }
    });

    // Task Management
    document.getElementById("addTask").addEventListener("click", function () {
        let taskInput = document.getElementById("taskInput");
        let taskText = taskInput.value.trim();

        if (taskText !== "") {
            let taskList = document.getElementById("taskList");
            let taskTime = new Date().toLocaleTimeString(); // Get current time

            let newTask = document.createElement("li");
            newTask.classList.add("list-group-item", "d-flex", "justify-content-between", "align-items-center");

            newTask.innerHTML = ` 
                <span class="task-text">${taskText} <small class="text-muted">(${taskTime})</small></span>
                <div>
                    <button class="btn btn-success btn-sm mark-done">✅ Mark Done</button>
                    <button class="btn btn-danger btn-sm delete-task">❌</button>
                </div>
            `;

            taskList.appendChild(newTask);
            taskInput.value = "";
        }
    });

    // Mark Task as Completed or Delete
    document.getElementById("taskList").addEventListener("click", function (e) {
        if (e.target.classList.contains("delete-task")) {
            e.target.closest("li").remove();
        }

        if (e.target.classList.contains("mark-done")) {
            let taskItem = e.target.closest("li");
            let taskText = taskItem.querySelector(".task-text");

            if (!taskItem.classList.contains("completed")) {
                taskItem.classList.add("completed", "bg-success", "text-white");
                taskText.style.textDecoration = "line-through";
                e.target.textContent = "🔄 Undo";
            } else {
                taskItem.classList.remove("completed", "bg-success", "text-white");
                taskText.style.textDecoration = "none";
                e.target.textContent = "✅ Mark Done";
            }
        }
    });
});
