using System.Globalization;

namespace FamilyTree
{
    class FamilyTree
    {
        public static List<Person> FamilyMembers { get; set; }

        public static Person TargetMember { get; private set; }

        public static void Create()
        {
            FamilyMembers = new List<Person>();
        }

        public static void SetTargetMember(string targetPerson)
        {
            TargetMember = GetPerson(targetPerson);
        }

        public static void AddMember(Person familyMember)
        {
            FamilyMembers.Add(familyMember);
        }

        public static void AddRelation(Person parent, Person child)
        {
            parent.FamilyInfo.Children.Add(child);
            child.FamilyInfo.Parents.Add(parent);
        }

        public static void AddRelation(string relation)
        {
            var p1Info = relation.Split('-').Select(p => p.Trim()).First();
            var p2Info = relation.Split('-').Select(p => p.Trim()).Last();

            Person person1 = GetPerson(p1Info);
            Person person2 = GetPerson(p2Info);

            AddRelation(person1, person2);

        }

        private static Person GetPerson(string personInfo)
        {
            Person person;

            var isInfoDate = DateTime.TryParseExact(personInfo, "d/M/yyyy", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime personBirthDate);

            if (!isInfoDate)
                person = FamilyMembers.Where(p => p.Name == personInfo).First();
            else
                person = FamilyMembers.Where(p => p.BirthDate == personBirthDate).First();

            return person;
        }
    }
}
