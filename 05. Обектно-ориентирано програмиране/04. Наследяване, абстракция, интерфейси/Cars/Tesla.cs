namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }

        public string Color { get; private set; }

        public int Battery { get; private set; }

        public string Start() => "Engine start!";

        public string Stop() => "Breaaak!";

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public override string ToString()
        {
            return String.Format("{0} Tesla {1} with {2} Batteries", Color, Model, Battery);
        }
    }
}