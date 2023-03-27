namespace FamilyTree
{
    class Person
    {
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public FamilyInfo FamilyInfo { get; set; }

        public Person()
        {
            this.FamilyInfo = new FamilyInfo();
        }

        public Person(string name) : this()
        {
            this.Name = name;
        }

        public Person(DateTime birthDate) : this()
        {
            this.BirthDate = birthDate;
        }

        public Person(string name, DateTime birthDate)
            : this(name)
        {
            this.BirthDate = birthDate;
        }

        public FamilyInfo GetFamilyInfo()
        {
            return this.FamilyInfo;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.BirthDate.ToString("d/M/yyyy")}";
        }
    }
}
