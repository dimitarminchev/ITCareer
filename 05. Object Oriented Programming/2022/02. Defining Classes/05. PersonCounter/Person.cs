/// <summary>
/// Клас човек
/// </summary>
public class Person
{
    private string name;

    /// <summary>
    /// Име на човека
    /// </summary>
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    /// <summary>
    /// Възраст на човека
    /// </summary>
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    /// <summary>
    /// Представяне
    /// </summary>
    public void IntroduceYourself()
    {
        Console.WriteLine("Hello! My name is {0} and I am {1} years old.", name, age);
    }

    private static int count = 0;

    /// <summary>
    /// Брой създадени обекти от този клас
    /// </summary>
    public static int Count 
    {
        get { return count; }
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        Person.count++;
    }
}