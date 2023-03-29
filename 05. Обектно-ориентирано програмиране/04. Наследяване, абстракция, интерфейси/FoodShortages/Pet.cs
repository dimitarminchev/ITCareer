namespace FoodShortages
{
    class Pet:INameAndBirthDate
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string birthDate;

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public Pet(string name,string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }
    }
}
