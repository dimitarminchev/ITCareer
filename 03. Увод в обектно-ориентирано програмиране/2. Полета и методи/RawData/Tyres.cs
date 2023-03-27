namespace RawData
{
    class Tyres
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private double nalqgane;

        public double Nalqgane
        {
            get { return nalqgane; }
            set { nalqgane = value; }
        }

        public Tyres(double nalqgane, int age)
        {
            this.nalqgane = nalqgane;
            this.age = age;
        }
    }
}
