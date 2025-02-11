document.getElementById("fetchUserBtn").addEventListener("click", async function () {
    const userCard = document.getElementById("userCard");
    const userImage = document.getElementById("userImage");
    const userName = document.getElementById("userName");
    const userEmail = document.getElementById("userEmail");

    const userDetails = document.getElementById("userDetails");
    const fullName = document.getElementById("fullName");
    const gender = document.getElementById("gender");
    const email = document.getElementById("email");
    const username = document.getElementById("username");
    const dob = document.getElementById("dob");
    const phone = document.getElementById("phone");
    const cell = document.getElementById("cell");
    const address = document.getElementById("address");
    const nationality = document.getElementById("nationality");

    try {
        // Fetch data from Random User API
        const response = await fetch("https://randomuser.me/api/");
        const data = await response.json();
        const user = data.results[0];

        // Populate user details
        userImage.src = user.picture.large;
        userName.textContent = `${user.name.title} ${user.name.first} ${user.name.last}`;
        userEmail.textContent = user.email;

        fullName.textContent = `${user.name.title} ${user.name.first} ${user.name.last}`;
        gender.textContent = user.gender;
        email.textContent = user.email;
        username.textContent = user.login.username;
        dob.textContent = `${new Date(user.dob.date).toLocaleDateString()} (Age: ${user.dob.age})`;
        phone.textContent = user.phone;
        cell.textContent = user.cell;
        address.textContent = `${user.location.street.number} ${user.location.street.name}, ${user.location.city}, ${user.location.state}, ${user.location.country}, ${user.location.postcode}`;
        nationality.textContent = user.nat;

        // Show the user card and details
        userCard.classList.remove("d-none");
        userDetails.classList.remove("d-none");

    } catch (error) {
        console.error("Error fetching user data:", error);
    }
});
