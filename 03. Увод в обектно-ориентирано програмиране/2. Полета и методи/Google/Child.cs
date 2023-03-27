namespace Google
{
    class Child
    {
        private string name;
        private string birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public override string ToString()
        {
            return $"{name} {birthday}";
        }
    }
}
