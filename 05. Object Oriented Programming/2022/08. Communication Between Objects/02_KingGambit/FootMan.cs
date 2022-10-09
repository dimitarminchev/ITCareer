public class FootMan : EventArgs
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public FootMan(string name)
    {
        Name = name;
    }

    public void Attack(object sender, EventArgs e)
    {
        Console.WriteLine($"Footman {name} is panicking!");
    }
}