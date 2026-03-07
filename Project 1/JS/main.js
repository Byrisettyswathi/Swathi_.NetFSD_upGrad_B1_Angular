import { getEvents, deleteEvent, updateEvent } from "./services/EventService.js";

const container = document.getElementById("eventsContainer");

async function loadEvents() {

    const events = await getEvents();

    container.innerHTML = "";

    events.forEach(event => {

        const card = document.createElement("div");

        card.className = "card";

        card.innerHTML = `
            <h3>${event.title}</h3>
            <p>${event.description}</p>
            <p>Date: ${event.date}</p>
            <p>Location: ${event.location}</p>
            <p>Seats: ${event.availableSeats}</p>

            <button class="update">Update</button>
            <button class="delete">Delete</button>
        `;

        card.querySelector(".delete").onclick = async () => {
            await deleteEvent(event.id);
            loadEvents();

        };

        card.querySelector(".update").onclick = async () => {
            const newTitle = prompt("Enter new title", event.title);

            if (newTitle) {

                event.title = newTitle;

                await updateEvent(event.id, event);

                loadEvents();

            }

        };

        container.appendChild(card);

    });

}

loadEvents();