namespace TrainsSkeleton {
    internal class Train {
        private readonly int number;
        private readonly string name;

        internal Train(int number, string name, string type, int cars) {
            this.number = number;
            this.name = name;
            Type = type;
            Cars = cars;
        }

        public string Type { get; }
        public int Cars { get; }

        public override string ToString() {
            return $"{number} {name} {Type} {Cars}";
        }
    }
}