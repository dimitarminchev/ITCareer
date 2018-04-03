using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    /// <summary>
    /// Човек
    /// </summary>
    class Person
    {
        // Име 
        private string name;
        public string Name { get { return name; } set { name = value;  }}

        // Възраст
        private int age;
        public int Age { get { return age; } set { age = value; } }

        // Банкови сметки
        private List<BankAccount> accounts = new List<BankAccount>();
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        // Суми
        public double GetBalance()
        {
            return accounts.Sum(element => element.Balance);
        }
    }

}
