namespace Employees
{
    public class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }

        private string employeeDepartment;

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }

        public FullTimeEmployee(string employeeDepartment, string employeePosition, string name, string id, string adress) : base(name, id, adress)
        {
            this.employeeDepartment = employeeDepartment;
            this.employeePosition = employeePosition;
        }
        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
        public void Show()
        {
            Console.WriteLine($"Employer {Name} with {ID} lives in {Adress} and works as {employeePosition} in {employeeDepartment}");
        }
    }
}
