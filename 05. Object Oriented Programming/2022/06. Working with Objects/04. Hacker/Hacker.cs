/// <summary>
/// Хакер
/// </summary>
public class Hacker
{
    /// <summary>
    /// Потребител
    /// </summary>
    public string username = "securityGod82";
    
    /// <summary>
    /// Парола
    /// </summary>
    public string Password
    {
        get => this.password;
        set => this.password = value;
    }
    private string password = "mySuperSecretPassw0rd";

    /// <summary>
    /// Идентификатор
    /// </summary>
    private int Id { get; set; }

    /// <summary>
    /// Сметка
    /// </summary>
    public double BankAccountBalance { get; private set; }

    /// <summary>
    /// Изтегли всички пари на света
    /// </summary>
    public void DownloadAllBankAccountsInTheWorld()
    {
        // не знам как
    }
}