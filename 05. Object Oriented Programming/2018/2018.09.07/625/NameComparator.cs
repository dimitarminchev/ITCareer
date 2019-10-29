using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _625
{
    class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return 1;
        }
    }
}
