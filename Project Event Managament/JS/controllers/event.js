import { addEvent } from "../services/EventService.js";

const form = document.getElementById("eventForm");

if (form) {

    form.addEventListener("submit", async function (e) {

        e.preventDefault();

        const title = document.getElementById("title").value;
        const description = document.getElementById("description").value;
        const date = document.getElementById("date").value;
        const location = document.getElementById("location").value;
        const seats = document.getElementById("seats").value;

        const eventData = {
                 title,
                description,
                date,
                location,
                capacity: seats,
                availableSeats: seats
};

        await addEvent(eventData);

        alert("Event Added Successfully");

        form.reset();

    });

}