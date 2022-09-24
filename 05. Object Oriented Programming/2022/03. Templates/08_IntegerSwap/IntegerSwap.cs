/// <summary>
/// Class to Swap Integers
/// </summary>
public class IntegerSwap<T>
{
    private T[] array;
    private int index;

    /// <summary>
    /// Constructor
    /// </summary>
    public IntegerSwap(int capacity)
    {
        array = new T[capacity];
        index = 0;
    }

    /// <summary>
    /// Add
    /// </summary>
    public void Add(T item)
    {
        array[index] = item;
        index++;
    }

    /// <summary>
    /// Swap
    /// </summary>
    public void Swap(int first, int second)
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;   
    }

    /// <summary>
    /// Print
    /// </summary>
    public void Print()
    {
        foreach (var item in array)
        {
            Console.WriteLine($"{item.GetType()}: {item}");
        }
    }
}