using System.Collections;

namespace BookComparator
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;

        private int CurrentBook;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => books[CurrentBook];

        object IEnumerator.Current => this.Current;

        public bool MoveNext() => ++CurrentBook < books.Count();

        public void Reset() => CurrentBook = -1;

        public void Dispose()
        {
            // nope
        }
    }
}