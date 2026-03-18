class BankAccount {
    accountHolder;
     balance = 0;

    constructor(name, amount) {
        this.accountHolder = name;
        this.balance = amount;
    }

    deposit(amount) {
        this.balance = this.balance +   amount;
        console.log(`${amount} deposited`);
    }

    withdraw(amount) {
        if (amount > this.balance) {
            console.log("Insufficient balance");
        } else {
            this.balance = this.balance - amount;
            console.log(`${amount} withdrawn`);
        }
    }

    checkBalance() {
        console.log(`Account Holder: ${this.accountHolder}`);
        console.log(`Balance: ${this.balance}`);
    }
}

let acc = new BankAccount("Rahul", 1000);
acc.deposit(500);
acc.withdraw(300);
acc.checkBalance();