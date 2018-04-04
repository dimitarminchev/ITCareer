using System;

class BankAccount
{
    private int id;
    private double balance;

    public BankAccount(int id)
    {
        this.id = id;
    }

    public double Balance => balance;

    public int ID => id;

    public void Deposit(double amount)
    {
        this.balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > this.balance)
        {
            throw new InvalidOperationException("Insufficient balance");
        }

        this.balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{this.id}, balance {this.Balance:F2}";
    }
}