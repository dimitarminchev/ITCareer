using System.Collections.Generic;
using System.Linq;

public class Controller
{
    private readonly Dictionary<string, Category> categories;

    public Controller()
    {
        categories = new Dictionary<string, Category>();
    }

    public string AddCategory(List<string> args)
    {
        string name = args[0];

        categories.Add(name, new Category(name));

        return $"Created Category {name}!";
    }

    public string AddJobOffer(List<string> args)
    {
        string name = args[0];
        string jobTitle = args[1];
        string company = args[2];
        double salary = double.Parse(args[3]);
        string type = args[4];

        if (type == "onsite")
        {
            string city = args[5];
            categories[name].AddJobOffer(new OnSiteJobOffer(jobTitle, company, salary, city));
        }

        if (type == "remote")
        {
            bool remote = bool.Parse(args[5]);
            categories[name].AddJobOffer(new RemoteJobOffer(jobTitle, company, salary, remote));
        }

        return $"Created JobOffer {jobTitle} in Category {name}!";
    }

    public string GetAverageSalary(List<string> args)
    {
        string name = args[0];

        var category = categories[name];
        if (category.jobOffers.Count == 0)
        {
            return "The average salary is: 0.00 BGN";
        }

        double averageSalary = category.AverageSalary();

        return $"The average salary is: {averageSalary:F2} BGN";
    }

    public string GetOffersAboveSalary(List<string> args)
    {
        string name = args[0];
        double salary = double.Parse(args[1]);

        var offers = categories[name].GetOffersAboveSalary(salary).OrderByDescending(x => x.Salary);
        foreach (var offer in offers)
        {
            offer.ToString();
        }

        return $"{string.Join("\n", offers)}";
    }

    public string GetOffersWithoutSalary(List<string> args)
    {
        string name = args[0];

        var offers = categories[name].GetOffersWithoutSalary().OrderBy(x => x.Company);
        foreach (var offer in offers)
        {
            offer.ToString();
        }

        return $"{string.Join("\n", offers)}";
    }
}