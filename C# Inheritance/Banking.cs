using System;

class Account
{
    public int AccountNumber { get; set; }
    public int Balance { get; set; }

    public void CalculateInterest()
    {
        Console.WriteLine("Base account interest calculation");
    }
}

class SavingsAccount : Account
{
    public new void CalculateInterest()
    {
        Console.WriteLine("Savings account interest calculation");
    }
}

class CurrentAccount : Account
{
    public new void CalculateInterest()
    {
        Console.WriteLine("Current account interest calculation");
    }
}

class Program
{
    static void Main()
    {
        Account acc;

        acc = new SavingsAccount();
        acc.AccountNumber = 101;
        acc.Balance = 5000;
        acc.CalculateInterest();

        acc = new CurrentAccount();
        acc.AccountNumber = 102;
        acc.Balance = 8000;
        acc.CalculateInterest();
    }
}