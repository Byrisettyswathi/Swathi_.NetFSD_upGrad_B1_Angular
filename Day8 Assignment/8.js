class Product {
    constructor({name, price, category = "General"}) {
        this.name = name;
        this.price = price;
        this.category = category;
    }

    showDetails = () => {
        console.log(`Product: ${this.name} Price: ${this.price} Category: ${this.category}`);
    }
}

let product1 = new Product({name: "Laptop", price: 50000, category: "HP"});
product1.showDetails();