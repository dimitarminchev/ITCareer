namespace Train
{
    /// <summary>
    /// Влак
    /// </summary>
    public class Train
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int cars;

        public int Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Train(int number, string name, string type, int cars)
        {
            this.Number = number;
            this.Name = name;
            this.Type = type;
            this.Cars = cars;
        }

        /// <summary>
        /// Пренаписване на метода ToString
        /// </summary>
        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Type} {this.Cars}";
        }
    }
}
