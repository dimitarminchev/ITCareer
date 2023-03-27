namespace Google
{
    class Company
    {
        private string name;
        private string department;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            if (name == null) return string.Empty;
            else return $"{name} {department} {salary}\n";
        }
    }
}
