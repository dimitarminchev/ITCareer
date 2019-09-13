using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ComparableBook
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Title, this.Year);
        }

        public int CompareTo(Book other)
        {
            if (this.Year < other.Year) return -1;
            else if (this.Year > other.Year) return 1;
            else return this.Title.CompareTo(other.Title);
        }
    }
}
