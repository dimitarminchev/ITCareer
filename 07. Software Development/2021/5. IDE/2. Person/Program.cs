using System;
using System.Collections.Generic;

/// <summary>
/// Person namespace
/// </summary>
namespace _2._Person
{
    /// <summary>
    /// Person main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Person main program method.
        /// </summary>
        /// <param name="args">Arguments from the command prompt.</param>
        static void Main(string[] args)
        {
            // Bank Accounts
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount(1, 100));
            accounts.Add(new BankAccount(2, 1200));
            accounts.Add(new BankAccount(3, 5000));

            // Person 
            Person ivan = new Person("Ivan Ivanov", 32, accounts);
            Console.WriteLine("Person: {0}, Age: {1}", ivan.Name, ivan.Age);
            Console.WriteLine("Total Bank Accounts Balance = {0}", ivan.GetBalance());

        }
    }
}
