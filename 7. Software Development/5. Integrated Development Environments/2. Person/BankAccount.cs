using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Person
{
    public class BankAccount
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

        public BankAccount(int id, double balance)
        {
            this.ID = id;
            this.Balance = balance;
        }

    }
}
