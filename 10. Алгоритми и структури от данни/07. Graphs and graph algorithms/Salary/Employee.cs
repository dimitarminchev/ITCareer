namespace Salary
{
    public class Employee
    {
        public int Index { get; set; }

        public List<int> Managers { get; set; }

        public List<int> Employees { get; set; }

        public int Salary { get; set; }

        public Employee(int index)
        {
            Index = index;
            Salary = 0;
            Employees = new List<int>();
            Managers = new List<int>();
        }
    }
}