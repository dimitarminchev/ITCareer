namespace Google
{
    class Car
    {
        private string model;
        private int speed;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public override string ToString()
        {
            return $"{model} {speed}\n";
        }
    }
}
