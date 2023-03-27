namespace CarsTravel
{
    class Car
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private float fuel;
        public float Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        private float perkm;
        public float Perkm
        {
            get { return perkm; }
            set { perkm = value; }
        }

        public void TheMagic(float km)
        {
            if (km * this.perkm > this.fuel) Console.WriteLine("Insufficient fuel for the drive");
            else
            {
                this.fuel -= (km * this.perkm);
                Console.WriteLine("{0} {1:f2} {2}", this.name, this.fuel, km);
            }
        }
    }
}
