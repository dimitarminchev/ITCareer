using System.Collections.Generic;

namespace Strategy
{
    public class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}