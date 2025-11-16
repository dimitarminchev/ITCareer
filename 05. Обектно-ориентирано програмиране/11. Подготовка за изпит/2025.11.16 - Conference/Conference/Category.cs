using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category
{
    private string name;
    private List<EventOffer> eventOffers;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 40)
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            name = value;
        }
    }

    public Category(string name)
    {
        Name = name;
        eventOffers = new List<EventOffer>();
    }

    public void AddEventOffer(EventOffer offer)
    {
        eventOffers.Add(offer);
    }

    public double AverageTicketPrice()
    {
        if (!eventOffers.Any())
            return 0.0;
        return eventOffers.Average(o => o.TicketPrice);
    }

    public List<EventOffer> GetOffersAboveDuration(int durationHours)
    {
        return eventOffers
            .Where(o => o.DurationHours >= durationHours)
            .OrderByDescending(o => o.DurationHours)
            .ToList();
    }

    public List<EventOffer> GetOffersWithTicketPrice()
    {
        return eventOffers
            .Where(o => Math.Abs(o.TicketPrice) > double.Epsilon)
            .OrderBy(o => o.Organizer, StringComparer.InvariantCulture)
            .ToList();
    }

    public override string ToString()
    {
        return $"Category {Name}{Environment.NewLine}Total Offers: {eventOffers.Count}";
    }
}
