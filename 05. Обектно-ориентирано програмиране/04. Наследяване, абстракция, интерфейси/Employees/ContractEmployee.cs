namespace Employees
{
    class ContractEmployee : BaseEmployee
    {
        private string employeeTask;

        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }
        private string employeeDepartment;

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }
        public ContractEmployee(string employeeTask, string employeeDepartment, string name, string id, string adress) : base(name, id, adress)
        {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }
        public void Show()
        {
            Console.WriteLine($"Employer {Name} with {ID} lives in {Adress} and works in {employeeDepartment} and is currently working on {employeeTask}");
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return employeeDepartment;
        }
    }
}
