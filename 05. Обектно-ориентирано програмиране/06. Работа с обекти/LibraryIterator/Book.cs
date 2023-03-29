namespace LibraryIterator
{
    public class Book
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
            return string.Format("{0}. {1}. {2}.", Title, Year, string.Join(", ", Authors));
        }
    }
}