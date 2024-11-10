using System;
using System.Text;

public class OnSiteJobOffer : JobOffer
{
	private string city;

	public string City
	{
		get 
		{ 
			return city; 
		}
		set 
		{
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("City should be between 3 and 30 characters!");
            }
            city = value; 
		}
	}

    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary)
    {
        City = city;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Job Title: {JobTitle}");
        sb.AppendLine($"Company: {Company}");
        sb.AppendLine($"Salary: {Salary:F2} BGN");
        sb.Append($"City: {City}");
        return sb.ToString();
    }
}