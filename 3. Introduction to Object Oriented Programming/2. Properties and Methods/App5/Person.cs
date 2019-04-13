using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Person
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        private List<BankAccount> accounts;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.accounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public double GetBalance()
        {
            return accounts.Sum(x => x.Balance);
        }
    }
    
}
