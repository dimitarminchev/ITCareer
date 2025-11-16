using CryptoMiningSystem.Entities;
using CryptoMiningSystem.Entities.Contracts;
using System;

public class User : IUser
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public User(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
    }

    /// <summary>
    /// Име
    /// </summary>
    private string name;

    public string Name
    {
        get { return name; }
        private set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Username must not be null or empty!");
            }
            name = value;
        }
    }

    /// <summary>
    /// Пари
    /// </summary>
    private decimal money;

    public decimal Money
    {
        get { return money; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("User's money cannot be less than 0!");
            }
            money = value; 
        }
    }

    // Звезди
    public int Stars
    {
        get { return System.Convert.ToInt32(Money) / 100; }
    }

    // Компютър
    public Computer Computer {  get; set; }

    public override string ToString()
    {
        return string.Format($"Name: {name} - Stars: {Stars}{Environment.NewLine}Balance: {money:f2}");
    }


}