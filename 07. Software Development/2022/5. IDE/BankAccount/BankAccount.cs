/// <summary>
/// Integrated Development Environment: "Bank Account" Namespace
/// </summary>
namespace BankAccount
{
    /// <summary>
    /// Integrated Development Environment: "Bank Account" Class
    /// </summary>
    public class BankAccount
    {
        private int id;

        /// <summary>
        /// Bank Account Identification Property
        /// </summary>
        public int Id
        {
            get { return id; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be positive number.");
                }
                id = value; 
            }
        }

        private double balance;

        /// <summary>
        /// Bank Account Balance
        /// </summary>
        public double Balance
        {
            get { return balance; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be positive number.");
                }
                balance = value; 
            }
        }

        /// <summary>
        /// Bank Account Constructor setting: Id and Balance
        /// </summary>
        public BankAccount(int id, double balance)
        {
            this.Id = id;
            this.Balance = balance;
        }
    }
}
