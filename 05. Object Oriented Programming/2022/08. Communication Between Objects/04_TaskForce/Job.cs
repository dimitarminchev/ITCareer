public class Job
{
	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	private Employee baseEmployee;

    private int hoursOfWorkRequired;

    public Job(string name, Employee employee, int hours)
	{
		this.Name = name;
		this.baseEmployee = employee;
		this.hoursOfWorkRequired = hours;
	}

	public void Update()
	{
        this.hoursOfWorkRequired -= baseEmployee.WorkHours;

        if (hoursOfWorkRequired <= 0)
        {
            Console.WriteLine($"Job {name} done!");
        }
    }

	public override string ToString()
	{
		return $"Job: {name} Hours Remaining: {hoursOfWorkRequired}"; ;	
	}
}