/// <summary>
/// Array Creator
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Create Array of Same Kind of Elements
    /// </summary>
    public static T[] Create<T>(int length, T item)
    {
        // Create the Array
        T[] array = new T[length];

        // Initialize the Array
        for (int i = 0; i < length; i++)
        {
            array[i] = item;
        }

        // Return the Array
        return array;
    }
}