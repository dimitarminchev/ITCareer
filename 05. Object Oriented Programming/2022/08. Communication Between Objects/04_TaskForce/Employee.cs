public class Employee
{
	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	private int workHours;

	public int WorkHours
	{
		get { return workHours; }
		set { workHours = value; }
	}

	public Employee(string name, int workHours = 0)
	{
		this.Name = name;
        this.WorkHours = workHours;
	}
}