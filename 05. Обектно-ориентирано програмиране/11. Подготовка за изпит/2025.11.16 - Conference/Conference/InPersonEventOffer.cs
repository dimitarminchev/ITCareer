using System;
using System.Globalization;
using System.Text;

public class InPersonEventOffer : EventOffer
{
    private string city;

    public string City
    {
        get => city;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 30)
                throw new ArgumentException("City should be between 3 and 30 characters!");
            city = value;
        }
    }

    public InPersonEventOffer(string eventTitle, string organizer, double ticketPrice, int durationHours, string city)
        : base(eventTitle, organizer, ticketPrice, durationHours)
    {
        City = city;
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + $"City: {City}";
    }
}

