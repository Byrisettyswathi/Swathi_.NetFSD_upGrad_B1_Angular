export class Registration {

    constructor(name, email, phone, eventId) {
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.eventId = eventId;
    }

    validateRegistration() {

        if (this.name.trim() === "") {
            return "Name is required";
        }

        if (!this.email.includes("@")) {
            return "Enter valid email";
        }

        if (this.phone.length !== 10) {
            return "Phone must be 10 digits";
        }

        return true;
    }

}