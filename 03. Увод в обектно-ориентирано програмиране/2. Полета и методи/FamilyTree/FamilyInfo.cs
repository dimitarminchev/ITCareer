namespace FamilyTree
{
    class FamilyInfo
    {
        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public FamilyInfo()
        {
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }
    }
}
