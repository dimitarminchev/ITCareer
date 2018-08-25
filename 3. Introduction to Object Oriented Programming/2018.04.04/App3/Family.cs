using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Family
    {
        private List<Person> people = new List<Person>();
        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public void Over30()
        {
            List<Person> over30 = new List<Person>();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Age > 30)
                    over30.Add(people[i]);
            }
            over30 = over30.OrderBy(x => x.Name).ToList();
            foreach (var person in over30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
