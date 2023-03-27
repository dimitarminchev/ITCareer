namespace Google
{
    class Pokemon
    {
        private string name;
        private string type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public override string ToString()
        {
            return $"{name} {type}";
        }
    }
}
