public class RoyalGuard : EventArgs
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int health;

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public RoyalGuard(string name)
    {
        this.Name = name;
        this.Health = 3;
    }

    public void Attack(object sender, EventArgs e)
    {
        if (this.Health > 0)
        {
            Console.WriteLine($"Royal Guard {name} is defending!");
        }
        if (this.health == 0)
        {
            return;
        }
        health--;
    }

}