using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class BankAccount
    {
        // Свойство "Номер на банкова сметка"
        private string iban;

        public string Iban
        {
            get { return iban; }
            set { iban = value; }
        }

        // Свойство "Баланс по банкова сметка"
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Внясяне на пари в сметката
        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        // Теглене на пари от сметката
        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
        }

        // Препокриване на метод
        public override string ToString()
        {
            return $"Account {this.iban}, balance {this.balance}";
        }
    }
}
