using System;
using _1
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Person
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private List<BankAccount> accounts;

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        public double GetBalance()
        {
            double balance = 0;
            foreach(var account in accounts)
            {
                balance += account.Balance;
            }
            return balance;
        }
    }
}
