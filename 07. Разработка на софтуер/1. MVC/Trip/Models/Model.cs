namespace Trip.Models
{
    public class Model
    {
        private double budget;

        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        private string season;

        public string Season
        {
            get { return season; }
            set { season = value; }
        }

        private string place;

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        private double expenses;

        public double Expenses
        {
            get { return expenses; }
            set { expenses = value; }
        }

        private string facility;

        public string Facility
        {
            get { return facility; }
            set { facility = value; }
        }

        public Model(double budget, string season)
        {
            this.budget = budget;
            this.season = season;
            this.place = "";
            this.facility = "";
            this.expenses = 0.0;
        }

        public Model() : this(0, "") 
        {
            // Empty
        }

        public string DefinePlace()
        {
            if (budget < 100)
            {
                place = "Bulgaria";
            }
            else if (budget >= 100 && budget < 1000)
            {
                place = "Balkans";
            }
            else
            {
                place = "Europe";
            }
            return place;
        }

        public double CalculateExpenses()
        {
            switch (this.place)
            {
                case "Bulgaria":
                    if (season == "summer")
                    {
                        this.facility = "Camp";
                        this.expenses = budget * 0.3;
                    }
                    else
                    {
                        this.facility = "Hotel";
                        this.expenses = budget * 0.7;
                    }
                    break;

                case "Balkans":
                    if (season == "summer")
                    {
                        this.facility = "Camp";
                        this.expenses = budget * 0.4;
                    }
                    else
                    {
                        this.facility = "Hotel";
                        this.expenses = budget * 0.8;
                    }
                    break;

                case "Europe":
                    this.facility = "Hotel";
                    this.expenses = budget * 0.9;
                    break;
            }
            return expenses;
        }
    }
}
