namespace BorderControl
{
    class Citizen : Data
    {
        private int age;

        public Citizen(string id, string name, int age) : base(id, name)
        {
            this.age = age;
        }
    }
}
