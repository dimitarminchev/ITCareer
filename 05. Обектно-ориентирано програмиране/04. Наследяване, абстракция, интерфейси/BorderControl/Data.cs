namespace BorderControl
{
    public abstract class Data
    {
        private string id;

        private string name;

        public string ID { get { return id; } }

        public Data(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
