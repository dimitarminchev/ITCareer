using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /// <summary>
    /// Човек
    /// </summary>
    public class Person
    {
        private string name;

        /// <summary>
        /// Име
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Value must not be empty!");
                }
                name = value; 
            }
        }

        private int age;

        /// <summary>
        /// Възраст
        /// </summary>
        public int Age
        {
            get { return age; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Value must be positive!");
                }
                age = value; 
            }
        }

        private List<BankAccount> accounts;

        /// <summary>
        /// Банкови сметки 
        /// </summary>
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Име</param>
        /// <param name="age">Възраст</param>
        /// <param name="accounts">Банкови сметки</param>
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Сума на баланс по всички сметки
        /// </summary>
        /// <returns>Тотал</returns>
        public double GetBalance()
        {
            double sum = this.Accounts.Sum(item => item.Balance);
            return sum;
        }
    }
}
