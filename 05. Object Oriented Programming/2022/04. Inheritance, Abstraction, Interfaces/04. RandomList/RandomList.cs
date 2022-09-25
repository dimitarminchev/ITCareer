using System.Collections;

public class RandomList : ArrayList
{
    private Random random = new Random();

    /// <summary>
    /// Remove random element from the list 
    /// </summary>
    /// <returns>Value of the removed object</returns>
    public object RandomObject()
    {
        var index = random.Next(0, base.Count - 1);
        object element = base[index];
        base.Remove(element);
        return element;
    }
}