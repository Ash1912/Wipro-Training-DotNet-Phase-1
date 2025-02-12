interface Contact {
    id: number;
    name: string;
    email: string;
    phone: string;
}

class ContactManager {
    private contacts: Contact[] = [];

    constructor() {
        this.loadContacts();
    }

    private saveContacts(): void {
        localStorage.setItem("contacts", JSON.stringify(this.contacts));
    }

    private loadContacts(): void {
        const storedContacts = localStorage.getItem("contacts");
        if (storedContacts) {
            this.contacts = JSON.parse(storedContacts);
        }
    }

    addContact(contact: Contact): void {
        this.contacts.push(contact);
        this.saveContacts();
        showAlert(`Contact added successfully: ${contact.name}`, "success");
        renderContacts();
    }

    viewContacts(): Contact[] {
        return this.contacts;
    }

    modifyContact(id: number, updatedContact: Partial<Contact>): void {
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

    deleteContact(id: number): void {
        this.contacts = this.contacts.filter(c => c.id !== id);
        this.saveContacts();
        showAlert("Contact deleted successfully.", "success");
        renderContacts();
    }
}

const manager = new ContactManager();

function addNewContact(): void {
    const nameInput = document.getElementById("contactName") as HTMLInputElement;
    const emailInput = document.getElementById("contactEmail") as HTMLInputElement;
    const phoneInput = document.getElementById("contactPhone") as HTMLInputElement;

    if (!nameInput.value || !emailInput.value || !phoneInput.value) {
        alert("Please enter all contact details.");
        return;
    }

    const newContact: Contact = {
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

function deleteContact(id: number): void {
    manager.deleteContact(id);
}

function modifyContact(id: number): void {
    const name = prompt("Enter new name:");
    const email = prompt("Enter new email:");
    const phone = prompt("Enter new phone:");

    if (name && email && phone) {
        manager.modifyContact(id, { name, email, phone });
    }
}

function renderContacts(): void {
    const contactTableBody = document.getElementById("contactTableBody") as HTMLTableSectionElement;
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
function showAlert(message: string, type: "success" | "error") {
    const alertBox = document.getElementById("alertBox") as HTMLDivElement;
    alertBox.textContent = message;
    alertBox.style.backgroundColor = type === "success" ? "#4CAF50" : "#e74c3c";
    alertBox.style.display = "block";
    setTimeout(() => {
        alertBox.style.display = "none";
    }, 3000);
}

// Function to show home page
function showHome() {
    document.getElementById("mainPage")!.style.display = "block";
    document.getElementById("contactListSection")!.style.display = "none";
}

// Function to show add contact form
function showAddContactForm() {
    document.getElementById("mainPage")!.style.display = "block";
    document.getElementById("contactListSection")!.style.display = "none";
}

// Function to show contact list
function showContactList() {
    document.getElementById("mainPage")!.style.display = "none";
    document.getElementById("contactListSection")!.style.display = "flex";
    renderContacts();
}

// Ensure contacts are loaded on page load
document.addEventListener("DOMContentLoaded", () => {
    renderContacts();
});

// Expose functions globally
(window as any).addNewContact = addNewContact;
(window as any).deleteContact = deleteContact;
(window as any).modifyContact = modifyContact;
(window as any).showAddContactForm = showAddContactForm;
(window as any).showContactList = showContactList;
(window as any).showHome = showHome;
