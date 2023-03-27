namespace RawData
{
    class Car
    {
        private Model carModel;

        public Model CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }
        private Tovar tovar;

        public Tovar Tovar
        {
            get { return tovar; }
            set { tovar = value; }
        }
        private Tyres[] carTyres = new Tyres[4];

        public Tyres[] CarTyres
        {
            get { return carTyres; }
            set { carTyres = value; }
        }

        public Car(Model model, Tovar tovar, Tyres[] tyres)
        {
            this.Tovar = tovar;
            this.carTyres = tyres;
            this.carModel = model;
        }
    }
}
