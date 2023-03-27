namespace RawData
{
    class Model
    {
        private string carModel;

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }

        private int engineSpeed;

        public int EngineSpeed
        {
            get { return engineSpeed; }
            set { engineSpeed = value; }
        }

        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public Model(string carModel, int engineSpeed, int power)
        {
            this.carModel = carModel;
            this.engineSpeed = engineSpeed;
            this.power = power;
        }
    }
}
