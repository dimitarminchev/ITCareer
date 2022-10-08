namespace _01_EventsDemo
{
    /// <summary>
    /// Делегат
    /// </summary>
    public delegate void NameChangeEventHandler();

    /// <summary>
    /// Диспечер
    /// </summary>
    public class Dispatcher
    {
        private string name { get; set; }

        private event NameChangeEventHandler nameChangeEventHandler;

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

    /// <summary>
    /// Аргументи
    /// </summary>
    public class NameChangeEventArgs : EventArgs
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public NameChangeEventArgs(string name)
        {
            this.name = name;
        }
    }

    /// <summary>
    /// Обработчик
    /// </summary>
    public class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine("Dispatcher's name changed to " + args.Name);
        }
    }

    /// <summary>
    /// Главна програма
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dp = new Dispatcher();

            var line = Console.ReadLine();
            while (line != "End")
            {
                dp.Name = line;
                line = Console.ReadLine();
            }
        }
    }
}