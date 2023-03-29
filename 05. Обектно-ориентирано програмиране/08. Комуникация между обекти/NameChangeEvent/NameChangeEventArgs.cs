namespace NameChangeEvent
{
    class NameChangeEventArgs : EventArgs
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public NameChangeEventArgs(string n)
        {
            name = n;
        }
    }
}
