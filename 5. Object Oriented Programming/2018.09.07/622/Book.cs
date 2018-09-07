using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _622
{
    class Book : IComparable<Book>
    {
        public string Name { get; private set; }
        public int Year { get; private set; }
        public List<string> Authors { get; private set; }

        public Book(string Name, int Year, params string[] Authors)
        {
            this.Name = Name;
            this.Year = Year;
            this.Authors = new List<string>(Authors);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Year}";
        }

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if(result==0)
            {
                result = this.Name.CompareTo(other.Name);
            }
            return result;
        }
    }
}
