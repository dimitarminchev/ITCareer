namespace _6_VSTT
{
    // Банкова сметка
    public class Account
    {
        // Баланс
        private decimal balance;
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        // Внасяне
        public void Deposit(decimal balance)
        {
            this.balance += balance;
        }

        // Теглене
        public void Withdraw(decimal balance)
        {
            this.balance -= balance;
        }

        // Трансфер
        public void Transfer(Account destination, decimal amount)
        {
            this.balance -= amount;
            destination.balance += amount;
        }
    }
}
