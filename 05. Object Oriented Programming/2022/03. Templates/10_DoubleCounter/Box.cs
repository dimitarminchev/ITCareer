/// <summary>
/// The Box
/// </summary>
public class Box<T> where T : IComparable
{
    private List<T> items;

    public int Count { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Box()
    {
        items = new List<T>();
        Count = 0;
    }

    /// <summary>
    /// Add
    /// </summary>
    public void Add(T item)
    {
        items.Add(item);
        Count++;
    }

    /// <summary>
    /// Remove
    /// </summary>
    public T Remove()
    {
        T temp = items.Last();
        items.Remove(items.Last());
        Count--;
        return temp;
    }

    public override string ToString()
    {
        string temp = null, type = null;
        foreach (T item in items)
        {
            type = item.GetType().ToString();
            temp += item.ToString();
        }
        return $"{type}: {temp}";
    }

    public void Print()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"{item.GetType()}: {item}");
        }
    }

    /// <summary>
    /// Count Number of Elements Bigger than
    /// </summary>
    public int BiggerThan(T element)
    {
        int count = 0;
        foreach (var item in items)
        {
            if (item.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }
}