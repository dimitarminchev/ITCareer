using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Person namespace
/// </summary>
namespace _2._Person
{
    /// <summary>
    /// Person Class 
    /// </summary>
    public class Person
    {
        private string name;

        /// <summary>
        /// Person Class Name Property.
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be null or empty.");
                }
                name = value; 
            }
        }


        private int age;

        /// <summary>
        /// Person Class Age Property.
        /// </summary>
        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive.");
                }
                age = value; 
            }
        }

        private List<BankAccount> accounts;

        /// <summary>
        /// Person Class Bank Accounds Collection Property.
        /// </summary>
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        /// <summary>
        /// Person Class Constructor.
        /// </summary>
        /// <param name="name">Person name</param>
        /// <param name="age">Person age</param>
        /// <param name="accounts">Bank Accounts List</param>
        public	Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Person Class get balance sum method.
        /// </summary>
        /// <returns>Returns balances sum.</returns>
        public double GetBalance()
        {
            return Accounts.Sum(item => item.Balance);
        }
    }
}
