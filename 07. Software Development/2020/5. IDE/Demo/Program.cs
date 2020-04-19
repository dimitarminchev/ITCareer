using System;
using System.Collections.Generic;

namespace Demo
{
    /// <summary>
    /// Програма
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Главен метод на програмата
        /// </summary>
        /// <param name="args">Аргументи</param>
        static void Main(string[] args)
        {
            // Банкови сметки
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount(42, 123.45));
            accounts.Add(new BankAccount(43, 234.56));
            accounts.Add(new BankAccount(45, 345.67));

            // Човек
            Person person = new Person("Ivan Ivanov", 23, accounts);
            Console.WriteLine("Name = {0}", person.Name);

            // Налични сметки на човека
            foreach (var account in person.Accounts)
            {
                Console.WriteLine(account.ToString());
            }

            // Обща сума по банковите сметки
            Console.WriteLine("Total Balance = {0}", person.GetBalance());
        }
    }
}
