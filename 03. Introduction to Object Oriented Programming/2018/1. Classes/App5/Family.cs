using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    /// <summary>
    /// Фамилия
    /// </summary>
    class Family
    {
        // Списък
        private List<Person> members = new List<Person>();

        // Добавяне 
        public void AddMember(Person member)
        {
            members.Add(member);
        }

        // Най-възрастен
        public Person GetOldestMember()
        {
            var list = members.OrderByDescending(a => a.Age).ToList();
            return list[0];
        }
    }
}
