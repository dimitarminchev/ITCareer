using System;
using System.Collections.Generic;
using System.Text;

static class AccountManager
{
    static Dictionary<int, BankAccount> database = new Dictionary<int, BankAccount>();

    public static void Create(int id)
    {
        if (!database.ContainsKey(id))
            database.Add(id, new BankAccount(id));
        else
            throw new InvalidOperationException("Account already exists");
    }

    public static void Deposit(int id, double amount)
    {
        if (!database.ContainsKey(id))
            throw new InvalidOperationException("Account does not exist");
        else
            database[id].Deposit(amount);
    }

    public static void Withdraw(int id, double amount)
    {
        if (!database.ContainsKey(id))
            throw new InvalidOperationException("Account does not exist");
        else
            database[id].Withdraw(amount);
    }

    public static string GetAccountInformation(int id)
    {
        if (!database.ContainsKey(id))
            throw new InvalidOperationException("Account does not exist");
        else
            return database[id].ToString();
    }
}