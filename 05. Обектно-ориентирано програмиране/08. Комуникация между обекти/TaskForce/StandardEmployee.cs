namespace TaskForce
{
    class StandartEmployee : Employee
    {
        int workHours = 40;

        public StandartEmployee(string name) : base(name) { base.WorkHours = 40; }
    }
}
