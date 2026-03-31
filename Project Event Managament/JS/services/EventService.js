const BASE_URL = "http://localhost:3000/events";

export async function getEvents() {

    const response = await fetch(BASE_URL);

    return await response.json();

}

export async function addEvent(eventData) {

    await fetch(BASE_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(eventData)
    });

}

export async function updateEvent(id, updatedData) {

    await fetch(`${BASE_URL}/${id}`, {
        method: "PUT",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(updatedData)
    });

}

export async function deleteEvent(id) {

    await fetch(`${BASE_URL}/${id}`, {
        method: "DELETE"
    });

}