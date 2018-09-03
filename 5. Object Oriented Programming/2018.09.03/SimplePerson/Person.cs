using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePerson
{
    // Човек
    public class Person
    {
        // Име
        private string name;
        public String Name
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

        // Конструктор
        public Person(string name = "Никой", int age = 0)
        {
            this.accounts =  new List<BankAccount>();
            this.name = name;
            this.age = age;
        }

        // Представяне
        public void Introduce()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }

        // Информация за банковите сметки
        private List<BankAccount> accounts;
        public List<BankAccount> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        // Информация за общата сума по банковите сметки 
        public double GetBalance()
        {
            return accounts.Sum(element => element.Balance);
        }

    }

}
