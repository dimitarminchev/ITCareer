namespace TaskForce
{
    class PartTimeEmployee : Employee
    {
        public static int workHours;

        public PartTimeEmployee(string name) : base(name) { base.WorkHours = 20; }
    }
}
