/// <summary>
/// Книга
/// </summary>
public class Book
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
        return string.Format("{0}. {1}. {2}.", Title, Year, string.Join(", ", Authors));
    }
}