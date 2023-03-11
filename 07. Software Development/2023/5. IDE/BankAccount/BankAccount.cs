/// <summary>
/// Task "BankAccount" namespace.
/// </summary>
namespace BankAccount
{
    /// <summary>
    /// Task "BankAccount" BankAccount class.
    /// </summary>
    public class BankAccount
    {
        private int id;

        /// <summary>
        /// Bank Account Identifier
        /// </summary>
        public int Id
        {
            get { return id; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be positive.");
                }
                id = value; 
            }
        }

        private decimal balance;

        /// <summary>
        /// Bank Account Balance
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be positive.");
                }
                balance = value; 
            }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BankAccount() : this(0,0)
        {
           // empty
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="id">Bank Account Identifier</param>
        /// <param name="balance">Bank Account Balance</param>
        public BankAccount(int id, decimal balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"Id: {this.Id}, Balance: {this.Balance}");
        }
    }
}
