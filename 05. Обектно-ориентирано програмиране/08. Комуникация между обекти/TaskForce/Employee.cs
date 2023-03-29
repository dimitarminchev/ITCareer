namespace TaskForce
{
    abstract class Employee
    {
        string name;
        int workHours;

        public Employee(string n)
        {
            name = n;
        }

        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
