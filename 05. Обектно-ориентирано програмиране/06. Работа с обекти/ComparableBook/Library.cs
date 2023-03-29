using System.Collections;

namespace ComparableBook
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books = this.books
                .OrderBy(book => book.Year)
                .ThenBy(book => book.Title).ToList();
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