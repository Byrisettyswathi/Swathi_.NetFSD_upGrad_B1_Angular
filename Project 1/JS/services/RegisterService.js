const BASE_URL = "http://localhost:3000/registrations";

export async function addRegistration(registrationData) {

    await fetch(BASE_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(registrationData)
    });

}