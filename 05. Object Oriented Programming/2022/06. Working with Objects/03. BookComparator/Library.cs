using System.Collections;

/// <summary>
/// Библиотека
/// </summary>
public class Library : IEnumerable<Book>
{
    /// <summary>
    /// Колекция от книги
    /// </summary>
    public List<Book> books { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);

        // Автоматично сортиране на книгите в библиотеката
        // 1. Заглавия [A..Z]
        // 2. Годнини [9..0]
        this.books = this.books
                     .OrderBy(book => book.Title)
                     .ThenByDescending(book => book.Year).ToList();
    }

    /// <summary>
    /// Обхождане на колекцията от книги
    /// </summary>
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