using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class BankAccount
    {
        // Номер на банкова сметка
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Баланс по банкова сметка
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Внясяне на пари в сметката
        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        // Теглене на пари от сметката
        public void Withdraw(double amount)
        {
            if (amount > this.balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.balance -= amount;
            }
        }

        // Печатаща функция
        public void Print()
        {
            Console.WriteLine($"Account ID{id}, balance {balance}");
        }
    }
}
