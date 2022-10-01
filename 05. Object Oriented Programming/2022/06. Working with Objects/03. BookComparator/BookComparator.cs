/// <summary>
/// Сравняване на две книги
/// </summary>
public class BookComparator : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        // 1. Сравняваме книгите по заглавие [A..Z]
        int result = x.Title.CompareTo(y.Title); // [-1 0 1]

        // Ако книгите са с еднакви заглавия, то..
        if (result == 0)
        {
            // 2. Сравняваме по години [9..0]
            result = y.Year.CompareTo(x.Year);
        }

        return result;
    }
}