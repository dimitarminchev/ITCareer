using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03_BookComparator
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books = this.books.OrderBy(book => book.Title).ThenByDescending(book => book.Year).ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            foreach (var book in books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}
