﻿namespace PersonStrategy
{
    public class PersonNameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var comparison = x.Name.Length - y.Name.Length;

            return comparison == 0
                ? (int)(char.ToLower(x.Name[0]) - char.ToLower(y.Name[0]))
                : comparison;
        }
    }
}