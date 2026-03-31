import { addRegistration } from "../services/RegisterService.js";
import Registration from "../models/register.js";

const registerForm = document.getElementById("registerForm");

if (registerForm) {

    registerForm.addEventListener("submit", async function (e) {

        e.preventDefault();

        const name = document.getElementById("name").value;
        const email = document.getElementById("email").value;
        const phone = document.getElementById("phone").value;
        const eventId = document.getElementById("eventSelect").value;

        const registration = new Registration(
            null,
            eventId,
            name,
            email,
            phone
        );

        const validation = registration.validateRegistration();

        if (validation !== true) {
            alert(validation);
            return;
        }

        await addRegistration(registration);

        alert("Registration Successful");

        registerForm.reset();

    });

}