namespace Employees
{
    public abstract class BaseEmployee
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public BaseEmployee(string name, string id, string adress)
        {
            this.adress = adress;
            this.name = name;
            this.id = id;
        }
        public BaseEmployee()
        {

        }
        public void Show()
        {
            Console.WriteLine($"Employer {name} with {id} lives in {adress}");
        }
        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
