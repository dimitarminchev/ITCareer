using System;
using System.Collections.Generic;
using System.Text;

public class RemoteJobOffer : JobOffer
{
	private bool fullyRemote;

    public bool FullyRemote
    {
		get 
		{ 
			return fullyRemote; 
		}
		set 
		{ 
			fullyRemote = value; 
		}
	}

    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        FullyRemote = fullyRemote;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Job Title: {JobTitle}");
        sb.AppendLine($"Company: {Company}");
        sb.AppendLine($"Salary: {Salary:F2} BGN");
        sb.Append("Fully Remote: " + (FullyRemote ? "yes" : "no"));
        return sb.ToString();
    }
}