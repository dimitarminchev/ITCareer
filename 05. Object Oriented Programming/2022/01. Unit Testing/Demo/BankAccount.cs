namespace Demo
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
			set { this.amount = value; }
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
