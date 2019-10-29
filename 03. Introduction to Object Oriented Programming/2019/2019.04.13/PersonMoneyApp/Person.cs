using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonMoneyApp
{
    class Person
    {
        // Свойство "Списък с банкoви сметки"
        private List<BankAccount> accounts = new List<BankAccount>();

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { List<BankAccount> accounts = value; }
        }

        // Свойство "Име човечето"
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Свойство "Възраст на човечето"
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Метод Представи се!
        public void IntroduceYourself()
        {
            Console.WriteLine("Greetings! I am {0} and I am {1} years old.", name, age);
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
        }

        // Метод за намиране на сумата по банковите сметки на човечето
        public decimal GetBalance()
        {
            return this.accounts.Sum(item => item.Balance);
        }
    }
}
