using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class BankAccount
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public override string ToString()
        {
            return $"{id} -> {balance:f2}";
        }
    }
}
