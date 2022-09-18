namespace _01._BankAccount
{
    /// <summary>
	/// Bank account
	/// </summary>
    public class BankAccount
    {
        private decimal amount;

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount
        {
            get { return this.amount; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Must be positive");
                }
                this.amount = value;
            }
        }

        /// <summary>
        /// Deposit
        /// </summary>
        public void Deposit(decimal cash)
        {
            this.Amount += cash;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BankAccount()
        {
            this.amount = 0;
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        public BankAccount(decimal account)
        {
            this.amount = account;
        }
    }
}
