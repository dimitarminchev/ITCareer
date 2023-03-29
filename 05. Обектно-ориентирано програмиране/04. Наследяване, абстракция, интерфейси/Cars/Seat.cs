namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start() => "Engine start!";

        public string Stop() => "Breaaak!";

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return String.Format("{0} Seat {1}", Color, Model);
        }
    }
}