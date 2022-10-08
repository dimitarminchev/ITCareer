public class StandartEmployee : Employee
{
    int workHours => 40;

	public StandartEmployee(string name) : base(name, 40)
	{
        // base.WorkHours = 40; 
    }
}