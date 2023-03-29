namespace NameChangeEvent
{
    public delegate void NameChangeEventHandler();

    class Dispatcher
    {
        private string name;
        private event NameChangeEventHandler NameChange;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnNameChange(new NameChangeEventArgs(name));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            Handler handler = new Handler();
            handler?.OnDispatcherNameChange(this, args);
        }
    }
}
