public class RoyalGuard 
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public RoyalGuard(string name)
    {
        Name = name;
    }

    public void Attack(object sender, EventArgs e)
    {
        Console.WriteLine($"RoyalGuard {name} is defending!");
    }
}