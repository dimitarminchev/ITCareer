using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BookComparator
{
    public class BookComparator : IComparer<Book>

    {
        public int Compare(Book x, Book y)
        {
            int names = x.Title.CompareTo(y.Title);
            if (names == 0) return x.Year.CompareTo(y.Year);
            else return names;
        }
    }
}
