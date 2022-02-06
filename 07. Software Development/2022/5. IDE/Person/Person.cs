/// <summary>
/// Integrated Development Environment: "Person" Namespace
/// </summary>
namespace Person
{
    /// <summary>
    /// Integrated Development Environment: "Person" class
    /// </summary>
    public class Person
    {
        private string name;

        /// <summary>
        /// Person full name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value must be not Null or Empty.");
                }
                name = value; 
            }
        }

        private int age;

        /// <summary>
        /// Person age
        /// </summary>
        public int Age
        {
            get { return age; }
            set 
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Value must be positive number between 0 and 100");
                }
                age = value; 
            }
        }

        private List<BankAccount> accounts;

        /// <summary>
        /// Person bank accounts
        /// </summary>
        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        /// <summary>
        /// Person Conctructor.
        /// </summary>
        /// <param name="name">Person full name</param>
        /// <param name="age">Person age</param>
        /// <param name="accounts">Person bank accounts</param>
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Get person ballance of all bank accounts.
        /// </summary>
        /// <returns>The balance of all accounts of this person.</returns>
        public double GetBalance()
        {
            var sum = Accounts.Sum(item => item.Balance);
            return sum;
        }
    }
}
