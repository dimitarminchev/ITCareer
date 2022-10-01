using System.Collections;
using System.Reflection.Metadata.Ecma335;
/// <summary>
/// Итератор на библиотеката
/// </summary>
public class LibraryIterator : IEnumerator<Book>
{
    /// <summary>
    /// Колекция от книги
    /// </summary>
    private readonly List<Book> books;

    /// <summary>
    /// Текуща книга
    /// </summary>
    private int CurrentBook;

    /// <summary>
    /// Конструктор
    /// </summary>
    public LibraryIterator(IEnumerable<Book> books)
    {
        this.Reset();
        this.books = new List<Book>(books);
    }

    /// <summary>
    /// Текуща книга
    /// </summary>
    public Book Current => books[CurrentBook];

    object IEnumerator.Current => this.Current;

    /// <summary>
    /// Следваща книга
    /// </summary>
    public bool MoveNext() => ++CurrentBook < books.Count();

    /// <summary>
    /// Обратно в началото
    /// </summary>
    public void Reset() => CurrentBook = -1;

    public void Dispose()
    {
        // nope
    }
}