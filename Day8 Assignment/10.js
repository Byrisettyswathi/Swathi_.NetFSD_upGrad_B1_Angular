class Wallet {
    balance = 0;

    addMoney(amount) {
        this.balance = this.balance + amount;
    }

    spendMoney(amount) {
        if (amount > this.balance) {
            console.log("Not enough balance");
        } else {
            this.balance = this.balance + amount
        }
    }

    getBalance() {
        console.log("Balance:", this.balance);
    }
}

let w = new Wallet();
w.addMoney(1000);
w.spendMoney(300);
w.getBalance();