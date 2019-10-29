using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Banker
{
    class BankAccount
    {
        // Номер на сметка
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0) throw new ArgumentException("Id must be positive value.");
                else id = value;
            }
        }

        // Баланс по сметка
        private double balance;

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0) throw new ArgumentException("Balance must be positive value.");
                else balance = value;
            }
        }

        // Конструктор
        public BankAccount(int id, double balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        // Захранване на сметка
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        // Теглене от сметката
        public void Withdraw(double amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Insufficient balance.");
            }
            this.Balance -= amount;
        }

        // Препокриване / Пренаписване
        public override string ToString()
        {
            return $"Id: {this.Id}, Balance: {this.Balance}";
        }   
    }
}
