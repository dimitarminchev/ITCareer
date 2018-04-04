using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    /// <summary>
    /// Банкова сметка
    /// </summary>
    class BankAccount
    {
        // Идентификатор
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Баланс
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Внасяне
        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        // Теглене
        public void Withdraw(double amount)
        {
            if (this.balance < amount)
            {
               Console.WriteLine("Insufficient Balance.");
            }
            else this.balance -= amount;
        }

        // Предефиниране на метод
        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }
    }
}
