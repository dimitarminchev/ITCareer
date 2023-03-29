namespace Birthday
{
    class Citizen : Data
    {
        private int age;
        public string birthDate { get; }
        public Citizen(string name, int age, string  id,string birthDate) : base(id, name)
        {
            this.age = age;
            this.birthDate = birthDate;
        }
    }
}
