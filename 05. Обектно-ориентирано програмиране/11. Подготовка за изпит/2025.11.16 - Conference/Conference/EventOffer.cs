using System;
using System.Globalization;
using System.Text;

public abstract class EventOffer
{
    private string eventTitle;

    public string EventTitle
    {
        get => eventTitle;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Event title should be between 3 and 30 characters!");
            eventTitle = value;
        }
    }

    private string organizer;

    public string Organizer
    {
        get => organizer;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Organizer should be between 3 and 30 characters!");
            organizer = value;
        }
    }

    private double ticketPrice;

    public double TicketPrice
    {
        get => ticketPrice;
        set
        {
            if (value < 0)
                throw new ArgumentException("Ticket price should be 0 or positive!");
            ticketPrice = value;
        }
    }

    private int durationHours;

    public int DurationHours
    {
        get => durationHours;
        set
        {
            if (value < 10 || value > 50)
                throw new ArgumentException("Duration hours should be between 10 and 50!");
            durationHours = value;
        }
    }

    public EventOffer(string eventTitle, string organizer, double ticketPrice, int durationHours)
    {
        EventTitle = eventTitle;
        Organizer = organizer;
        TicketPrice = ticketPrice;
        DurationHours = durationHours;
    }

    public override string ToString()
    {
        return new StringBuilder()
            .AppendLine($"Event Title: {EventTitle}")
            .AppendLine($"Organizer: {Organizer}")
            .AppendLine($"Ticket Price: {TicketPrice.ToString("F2", CultureInfo.InvariantCulture)} BGN")
            .Append($"Duration: {DurationHours} hours")
            .ToString();
    }

}