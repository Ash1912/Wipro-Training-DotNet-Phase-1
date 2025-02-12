class ContactManager {
    constructor() {
        this.contacts = [];
        this.loadContacts();
    }
    saveContacts() {
        localStorage.setItem("contacts", JSON.stringify(this.contacts));
    }
    loadContacts() {
        const storedContacts = localStorage.getItem("contacts");
        if (storedContacts) {
            this.contacts = JSON.parse(storedContacts);
        }
    }
    addContact(contact) {
        this.contacts.push(contact);
        this.saveContacts();
        showAlert(`Contact added successfully: ${contact.name}`, "success");
        renderContacts();
    }
    viewContacts() {
        return this.contacts;
    }
    modifyContact(id, updatedContact) {
        const contact = this.contacts.find(c => c.id === id);
        if (!contact) {
            showAlert(`Error: Contact with ID ${id} not found.`, "error");
            return;
        }
        Object.assign(contact, updatedContact);
        this.saveContacts();
        showAlert(`Contact modified successfully: ${contact.name}`, "success");
        renderContacts();
    }
    deleteContact(id) {
        this.contacts = this.contacts.filter(c => c.id !== id);
        this.saveContacts();
        showAlert("Contact deleted successfully.", "success");
        renderContacts();
    }
}
const manager = new ContactManager();
function addNewContact() {
    const nameInput = document.getElementById("contactName");
    const emailInput = document.getElementById("contactEmail");
    const phoneInput = document.getElementById("contactPhone");
    if (!nameInput.value || !emailInput.value || !phoneInput.value) {
        alert("Please enter all contact details.");
        return;
    }
    const newContact = {
        id: Date.now(),
        name: nameInput.value,
        email: emailInput.value,
        phone: phoneInput.value,
    };
    manager.addContact(newContact);
    nameInput.value = "";
    emailInput.value = "";
    phoneInput.value = "";
}
function deleteContact(id) {
    manager.deleteContact(id);
}
function modifyContact(id) {
    const name = prompt("Enter new name:");
    const email = prompt("Enter new email:");
    const phone = prompt("Enter new phone:");
    if (name && email && phone) {
        manager.modifyContact(id, { name, email, phone });
    }
}
function renderContacts() {
    const contactTableBody = document.getElementById("contactTableBody");
    contactTableBody.innerHTML = "";
    manager.viewContacts().forEach(contact => {
        const row = document.createElement("tr");
        row.innerHTML = `
            <td>${contact.name}</td>
            <td>${contact.email}</td>
            <td>${contact.phone}</td>
            <td>
                <button onclick="modifyContact(${contact.id})">Modify</button>
                <button onclick="deleteContact(${contact.id})">Delete</button>
            </td>
        `;
        contactTableBody.appendChild(row);
    });
}
// Function to show alert messages
function showAlert(message, type) {
    const alertBox = document.getElementById("alertBox");
    alertBox.textContent = message;
    alertBox.style.backgroundColor = type === "success" ? "#4CAF50" : "#e74c3c";
    alertBox.style.display = "block";
    setTimeout(() => {
        alertBox.style.display = "none";
    }, 3000);
}
// Function to show home page
function showHome() {
    document.getElementById("mainPage").style.display = "block";
    document.getElementById("contactListSection").style.display = "none";
}
// Function to show add contact form
function showAddContactForm() {
    document.getElementById("mainPage").style.display = "block";
    document.getElementById("contactListSection").style.display = "none";
}
// Function to show contact list
function showContactList() {
    document.getElementById("mainPage").style.display = "none";
    document.getElementById("contactListSection").style.display = "flex";
    renderContacts();
}
// Ensure contacts are loaded on page load
document.addEventListener("DOMContentLoaded", () => {
    renderContacts();
});
// Expose functions globally
window.addNewContact = addNewContact;
window.deleteContact = deleteContact;
window.modifyContact = modifyContact;
window.showAddContactForm = showAddContactForm;
window.showContactList = showContactList;
window.showHome = showHome;
