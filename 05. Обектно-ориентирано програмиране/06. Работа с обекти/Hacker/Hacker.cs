namespace Hacker
{
    public class Hacker
    {
        public string username = "securityGod82";

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }
        private string password = "mySuperSecretPassw0rd";

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {
            // empty
        }
    }
}