namespace Transport.Models
{
    public class Model
    {
        private int kilometers;

        public int Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }

        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private double startPrice;

        public double StartPrice
        {
            get { return startPrice; }
            set { startPrice = value; }
        }

        public Model(int kilometres, string time)
        {
            Kilometers = kilometres;
            Time = time;
        }

        public Model() : this(0, "")
        {
            // nope
        }

        public double CalculateCheapest()
        {
            double pricePerKm = 0;
            if (kilometers < 20)
            {
                // Такси
                startPrice = 0.70;
                if (time == "day")
                    pricePerKm = 0.79;
                else
                    pricePerKm = 0.90;
            }
            else if (kilometers >= 20 && kilometers <= 100)
            {
                // Автобус
                startPrice = 0;
                pricePerKm = 0.09;
            }
            else
            {
                // Влак
                startPrice = 0;
                pricePerKm = 0.06;
            }
            return pricePerKm;
        }

        public double CalculatePrice()
        {
            return CalculateCheapest() * kilometers + startPrice;
        }
    }
}
