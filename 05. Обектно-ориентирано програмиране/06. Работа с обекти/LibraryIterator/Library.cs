using System.Collections;

namespace LibraryIterator
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}