using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category
{
    public List<JobOffer> jobOffers { get; private set; }

    private string name;

	public string Name
	{
		get 
		{ 
			return name; 
		}
		set 
		{
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value; 
		}
	}

    public Category(string name)
    {
        Name = name;
        jobOffers = new List<JobOffer>();
    }

    public void AddJobOffer(JobOffer offer)
	{
		jobOffers.Add(offer);
    }

    public double AverageSalary()
    {
        return jobOffers.Average(x => x.Salary);
    }

    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        return jobOffers.Where(x => x.Salary > salary).ToList();
    }

    public List<JobOffer> GetOffersWithoutSalary()
    {
        return jobOffers.Where(x => x.Salary == 0).ToList();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Category: {Name}");
        sb.Append($"Total Offers: {jobOffers.Count()}");
        return sb.ToString();
    }
}