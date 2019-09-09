namespace _1_BankAccount
{
    // Банкова сметка
    public class BankAccount
    {
        // Сметка
        private decimal balance;
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        // Конструктор
        public BankAccount(decimal amount = 0)
        {
            this.balance = amount;
        }

        // Внасяне на пари по сметка
        public void Deposit(decimal cash)
        {
            this.balance += cash;
        }
    }
}
