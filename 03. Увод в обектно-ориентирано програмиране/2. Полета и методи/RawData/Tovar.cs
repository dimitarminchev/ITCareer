namespace RawData
{
    class Tovar
    {
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Tovar(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
}
