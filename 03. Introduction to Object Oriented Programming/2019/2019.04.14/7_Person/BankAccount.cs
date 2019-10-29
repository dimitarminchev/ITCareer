using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Person
{
    class BankAccount
    {
        // Уникален идентификатор на банкова сметка
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        // Баланс на банкова сметка
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Конструктор
        public BankAccount() : this(0, 0)
        {
            ;;
        }

        public BankAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

        // Внасяне на пари по сметка
        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        // Теглене на пари от сметка
        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        // Препокриване на метод
        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }


    }
}
