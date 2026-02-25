class Shape {
    calculateArea() {
        console.log("Area not defined");
    }
}

class Circle extends Shape {
    constructor(radius) {
        super();
        this.radius = radius;
    }

    calculateArea() {
        console.log("Circle Area:", 3.14 * this.radius * this.radius);
    }
}

class Rectangle extends Shape {
    constructor(length, width) {
        super();
        this.length = length;
        this.width = width;
    }

    calculateArea() {
        console.log("Rectangle Area:", this.length * this.width);
    }
}

let shapes = [
    new Circle(5),
    new Rectangle(4, 6)
];

shapes.forEach(shape => shape.calculateArea());