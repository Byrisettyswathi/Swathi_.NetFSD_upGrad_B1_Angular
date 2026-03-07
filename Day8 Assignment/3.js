class Student {
    constructor(name, marks) {
        this.name = name;
        this.marks = marks; 
    }

    getAverage() {
        let sum = 0;

        for (let i = 0; i < this.marks.length; i++) {
            sum = sum + this.marks[i];
        }

        return sum / this.marks.length;
    }

    getGrade() {
        let avg = this.getAverage();

        if (avg >= 90) {
            return "A";
        } 
        else if (avg >= 75) {
            return "B";
        } 
        else if (avg >= 50) {
            return "C";
        } 
        else {
            return "Fail";
        }
    }

    showDetails() {
        console.log(`Name: ${this.name}`);
        console.log(`Marks: ${this.marks}`);
        console.log(`Average: ${this.getAverage()}`);
        console.log(`Grade: ${this.getGrade()}`);
    }
}

let s1 = new Student("Rahul", [80, 90, 70]);
s1.showDetails();