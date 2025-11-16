using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;


public class Controller
{
    private readonly Dictionary<string, Category> categories;

    public Controller()
    {
        categories = new Dictionary<string, Category>();
    }

    public string AddCategory(List<string> args)
    {
        // args[0] => name
        string name = args[0];
        var category = new Category(name);
        categories.Add(name, category);
        return $"Created Category {name}!";
    }

    public string AddEventOffer(List<string> args)
    {
        // args layout:
        // 0: categoryName
        // 1: eventTitle
        // 2: organizer
        // 3: ticketPrice
        // 4: durationHours
        // 5: type
        // 6: city or fullyVirtual
        string categoryName = args[0];
        string eventTitle = args[1];
        string organizer = args[2];
        double ticketPrice = double.Parse(args[3], CultureInfo.InvariantCulture);
        int durationHours = int.Parse(args[4], CultureInfo.InvariantCulture);
        string type = args[5];

        if (!categories.TryGetValue(categoryName, out var category))
            throw new ArgumentException("Category not found!");

        EventOffer offer;
        if (type == "inperson")
        {
            string city = args[6];
            offer = new InPersonEventOffer(eventTitle, organizer, ticketPrice, durationHours, city);
        }
        else if (type == "virtual")
        {
            bool fullyVirtual = bool.Parse(args[6]);
            offer = new VirtualEventOffer(eventTitle, organizer, ticketPrice, durationHours, fullyVirtual);
        }
        else
        {
            throw new ArgumentException("Unknown event offer type!");
        }

        category.AddEventOffer(offer);
        return $"Created EventOffer {eventTitle} in Category {categoryName}!";
    }

    public string GetAverageTicketPrice(List<string> args)
    {
        string categoryName = args[0];
        if (!categories.TryGetValue(categoryName, out var category))
            throw new ArgumentException("Category not found!");

        double avg = category.AverageTicketPrice();
        return $"The average ticket price is: {avg.ToString("F2", CultureInfo.InvariantCulture)} BGN";
    }

    public string GetOffersAboveDuration(List<string> args)
    {
        string categoryName = args[0];
        int duration = int.Parse(args[1], CultureInfo.InvariantCulture);
        if (!categories.TryGetValue(categoryName, out var category))
            throw new ArgumentException("Category not found!");

        var offers = category.GetOffersAboveDuration(duration);
        return string.Join(Environment.NewLine, offers.Select(o => o.ToString()));
    }

    public string GetOffersWithTicketPrice(List<string> args)
    {
        string categoryName = args[0];
        if (!categories.TryGetValue(categoryName, out var category))
            throw new ArgumentException("Category not found!");

        var offers = category.GetOffersWithTicketPrice();
        return string.Join(Environment.NewLine, offers.Select(o => o.ToString()));
    }

}
