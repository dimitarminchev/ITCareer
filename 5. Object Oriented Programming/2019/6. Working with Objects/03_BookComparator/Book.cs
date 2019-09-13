using System;
using System.Collections.Generic;

namespace _03_BookComparator
{
    public class Book 
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

    }
}
