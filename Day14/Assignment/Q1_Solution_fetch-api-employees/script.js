const apiUrl = "https://jsonplaceholder.typicode.com/users";
const viewOption = document.getElementById("viewOption");
const singleUserInput = document.getElementById("singleUserInput");
const employeeTableBody = document.getElementById("employeeTableBody");
const loadingText = document.querySelector(".loading");

// Function to Fetch Data Based on Selection
async function fetchEmployeeDetails() {
    employeeTableBody.innerHTML = "";
    loadingText.textContent = "Fetching data...";

    try {
        let response;
        let users;

        if (viewOption.value === "all") {
            response = await fetch(apiUrl);
            users = await response.json();
        } else if (viewOption.value === "single") {
            const userId = document.getElementById("userId").value;
            if (!userId) {
                loadingText.textContent = "Please enter a User ID.";
                return;
            }
            response = await fetch(`${apiUrl}/${userId}`);
            users = await response.json();
            users = [users]; // Convert to array for easier processing
        }

        if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
        }

        // Hide loading text
        loadingText.style.display = "none";

        users.forEach((user) => {
            const row = `
                <tr>
                    <td>${user.id}</td>
                    <td>${user.name}</td>
                    <td>${user.username}</td>
                    <td>${user.email}</td>
                    <td>${user.phone}</td>
                    <td><a href="https://${user.website}" target="_blank">${user.website}</a></td>
                    <td>${user.company.name}</td>
                    <td>${user.address.city}</td>
                </tr>
            `;
            employeeTableBody.innerHTML += row;
        });

    } catch (error) {
        loadingText.textContent = "Failed to load data!";
        console.error("Error fetching data:", error);
    }
}

// Show/Hide Input Field Based on Selection
viewOption.addEventListener("change", function () {
    employeeTableBody.innerHTML = "";
    loadingText.textContent = "Please select an option...";

    if (this.value === "single") {
        singleUserInput.classList.remove("d-none");
    } else {
        singleUserInput.classList.add("d-none");
        fetchEmployeeDetails(); // Fetch all users
    }
});
