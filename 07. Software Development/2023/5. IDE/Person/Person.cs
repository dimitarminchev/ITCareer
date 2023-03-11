using System.Security.Principal;
using System.Text;
/// <summary>
/// Task "Person" namespace.
/// </summary>
namespace Person
{
    /// <summary>
    /// Task "Person" BankAccount class.
    /// </summary>
    public class Person
    {
        private string name;

        /// <summary>
        /// Person Name
        /// Note: Name can not be null or empty.
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty.");
                }
                name = value; 
            }
        }

        private int age;

        /// <summary>
        /// Person Age
        /// Note: Age must be from 18 to 100.
        /// </summary>
        public int Age
        {
            get { return age; }
            set 
            {
                if (age >= 18 && age <= 100)
                {
                    throw new ArgumentException("Age must be from 18 to 100");
                }
                age = value; 
            }
        }

        private List<BankAccount> accounts;

        /// <summary>
        /// Person Bank Accounts
        /// Note: Collection must not be empty.
        /// </summary>
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set 
            {
                if (value == null && value.Count() > 0)
                {
                    throw new ArgumentException("Collection must not be empty.");
                }
                accounts = value; 
            }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Person() : this("Noname", 18, new List<BankAccount>())
        {
            // empty
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="name">Person name</param>
        /// <param name="age">Person Age</param>
        /// <param name="accounts">Person Bank Accounts</param>
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        /// <summary>
        /// ToString
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format($"Name: {this.Name}") + Environment.NewLine);
            sb.Append(string.Format($"Age: {this.Age}") + Environment.NewLine);
            sb.Append(string.Format($"Bank Accounts:") + Environment.NewLine);
            Accounts.ForEach(account => sb.Append(string.Format($"\t{account}") + Environment.NewLine));

            return sb.ToString();
        }
    }
}
