using System.Collections;
using System.Collections.Generic;

namespace _03_BookComparator
{
    internal class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;

        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;

        public bool MoveNext() => ++this.currentIndex < this.books.Count;

        public void Reset() => this.currentIndex = -1;

        public void Dispose()
        {
            // nope
        }
    }
}
