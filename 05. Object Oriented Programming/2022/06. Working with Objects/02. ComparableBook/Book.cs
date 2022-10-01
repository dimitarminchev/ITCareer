/// <summary>
/// Книга
/// </summary>
public class Book : IComparable<Book>
{
    /// <summary>
    /// Заглавие
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Година 
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Автори
    /// </summary>
    public IReadOnlyList<string> Authors { get; private set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors;
    }

    /// <summary>
    /// Пренаписваме ToString
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return string.Format($"{Title} - {Year}.");
    }

    /// <summary>
    /// Сравняване на книги
    /// </summary>
    public int CompareTo(Book other)
    {
        // 1. Сравянваме по години [0..9]
        int result = this.Year.CompareTo(other.Year); // [-1 0 1]

        // Ако годините са равни ..
        if (result == 0)
        { 
            // 2. Сравняваме по заглавия [A..Z]
            result = this.Title.CompareTo(other.Title); // [-1 0 1]
        }
        return result;
    }
}