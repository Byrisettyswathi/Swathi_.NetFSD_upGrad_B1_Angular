export function showError(message, elementId) {

    const element = document.getElementById(elementId);

    if (element) {
        element.textContent = message;
        element.style.color = "red";
    }

}

export function showSuccess(message, elementId) {

    const element = document.getElementById(elementId);

    if (element) {
        element.textContent = message;
        element.style.color = "green";
    }

}

export function clearMessage(elementId) {

    const element = document.getElementById(elementId);

    if (element) {
        element.textContent = "";
    }

}