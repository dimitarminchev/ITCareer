namespace Trip.Views
{
    public class View
    {
        public double budget { get; set; }

        public string season { get; set; }

        public string place { get; set; }

        public double expenses { get; set; }

        public string facility { get; set; }

        public View()
        {
            this.budget = 0;
            this.season = "";
            this.place = "";
            this.facility = "";
            this.expenses = 0.0;
            GetValues();
        }

        public void GetValues()
        {
            Console.WriteLine("Enter budget: ");
            this.budget = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter season (summer/winter)");
            this.season = Console.ReadLine();
        }

        public void ShowResult()
        {
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{facility} - {expenses:f2}");
        }
    }
}
