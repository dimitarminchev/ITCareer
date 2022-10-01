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
    /// <param name="books"></param>
    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    /// <summary>
    /// Обхождане на колекцията от книги
    /// </summary>
    /// <returns></returns>
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