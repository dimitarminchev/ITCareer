using System.Collections.Generic;
using System.Linq;

namespace _3_OldestMembeр
{
    class Family
    {
        // Списък хора
        private List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        // Добавяне на нов човек към списъка
        public void AddMember(Person member)
        {
            people.Add(member);
        }

        // Най-стария човек от списъка

        public Person GetOldestMember()
        {
            return people.OrderByDescending(person => person.Age).FirstOrDefault();
        }
       
    }
}
