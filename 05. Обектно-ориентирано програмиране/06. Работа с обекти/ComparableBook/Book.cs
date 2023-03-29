namespace ComparableBook
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; private set; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        public override string ToString()
        {
            return string.Format($"{Title} - {Year}.");
        }

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year); 
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title); 
            }
            return result;
        }
    }
}