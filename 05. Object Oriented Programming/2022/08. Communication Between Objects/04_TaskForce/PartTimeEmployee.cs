public class PartTimeEmployee : Employee
{
    public static int workHours;

	public PartTimeEmployee(string name) : base(name, 20)
	{
		// base.WorkHours = 20;
	}
}