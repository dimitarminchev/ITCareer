using System.Globalization;

namespace FamilyTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var targetPerson = Console.ReadLine();

            FamilyTree.Create();

            var information = new List<string>();
            string info;

            while ((info = Console.ReadLine()) != "End")
            {
                information.Add(info);
            }

            var newMembers = new List<string>(information.Where(s => !s.Contains('-')));

            foreach (var member in newMembers)
            {
                var parts = member.Split(' ');

                var birthDate = DateTime.ParseExact(parts.Last(), "d/M/yyyy",
                    CultureInfo.InvariantCulture);

                var name = string.Join(" ", parts.Take(parts.Length - 1));

                FamilyTree.AddMember(new Person(name, birthDate));
            }

            FamilyTree.SetTargetMember(targetPerson);

            var relations = new List<string>(information.Where(s => s.Contains('-')));

            foreach (var relation in relations)
            {
                FamilyTree.AddRelation(relation);
            }

            Console.WriteLine(FamilyTree.TargetMember);
            Console.WriteLine("Parents:");
            Console.WriteLine(String.Join(Environment.NewLine, FamilyTree.TargetMember.FamilyInfo.Parents));
            Console.WriteLine("Children");
            Console.WriteLine(String.Join(Environment.NewLine, FamilyTree.TargetMember.FamilyInfo.Children));
        }
    }
}