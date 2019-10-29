using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Person
{
    class Person
    {
        // Име
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Банкови сметки
        private List<BankAccount> accounts;

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        // Конструктори
        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        {
            ;;
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        // Връща баланса по всички сметки  на човека
        public double GetBalance()
        {
            return this.accounts.Sum(item => item.Balance);
        }
    }
}
