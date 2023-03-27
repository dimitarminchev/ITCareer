namespace Google
{
    class Person
    {
        private Company company;
        private Car car;
        private List<Pokemon> pokemons;
        private List<Child> children;
        private List<Parent> parents;

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }
        public Car Car
        {
            get { return car; }
            set { car = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }
        public List<Child> Children
        {
            get { return children; }
            set { children = value; }
        }
        public List<Parent> Parents
        {
            get { return parents; }
            set { parents = value; }
        }
    }
}
