using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _622
{
    class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int result = x.Name.CompareTo(y.Name);
            if(result==0)
            {
                result = -x.Year.CompareTo(y.Year);
            }
            return result;
        }
    }
}
