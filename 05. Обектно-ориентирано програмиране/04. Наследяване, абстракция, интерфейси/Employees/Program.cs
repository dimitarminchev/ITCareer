namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractEmployee employee = new ContractEmployee("Math Problems","Second Floor","Gosho","0123","Sliven");
            employee.Show();
            Console.WriteLine( employee.CalculateSalary(48));
        }
    }
}
