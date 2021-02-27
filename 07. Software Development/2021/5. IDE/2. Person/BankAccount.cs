namespace _2._Person
{
    /// <summary>
    /// Bank Accound Class.
    /// </summary>
    public class BankAccount
    {
        private int id;

        /// <summary>
        /// Bank Account class Id property.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private double balance;

        /// <summary>
        /// Bank Accound class Balance property.
        /// </summary>
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        /// <summary>
        /// Bank Accound Constructor
        /// </summary>
        public BankAccount()
        {
            this.Id = 0;
            this.Balance = 0;
        }

        /// <summary>
        /// Bank Accound Constructor
        /// </summary>
        /// <param name="id">Identificator</param>
        /// <param name="balance">Inital balance</param>
        public BankAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

    }
}
