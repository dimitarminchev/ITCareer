using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Banker
{
    class Bank
    {
        // Списък със банкови сметки
        private static List<BankAccount> accounts;

        // Конструктор
        static Bank()
        {
            accounts = new List<BankAccount>();
        }

        // Захранване на сметка
        public static void Deposit(int id, double amount)
        {
            // Проверка дали съществува такава банкова сметка
            var account = accounts.Where(item => item.Id == id).FirstOrDefault();
            if (account == null)
            {
                accounts.Add(new BankAccount(id, amount));
            }
            else
            {
                accounts.Where(item => item.Id == id).First().Deposit(amount);
            }
        }
        // Теглене от сметка
        public static void Withdraw(int id, double amount)
        {
            // Проверка дали съществува такава банкова сметка
            var account = accounts.Where(item => item.Id == id).FirstOrDefault();
            if (account == null)
            {
                throw new ArgumentException("Bank account does not exists.");
            }
            else
            {
                accounts.Where(item => item.Id == id).First().Withdraw(amount);
            }
        }

        // Печат
        public static void Print()
        {
            accounts.ForEach(account => Console.WriteLine(account));
        }
    }
}
