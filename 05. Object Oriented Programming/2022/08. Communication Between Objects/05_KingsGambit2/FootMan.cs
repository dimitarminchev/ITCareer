public class FootMan : EventArgs
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

    public FootMan(string name)
    {
        this.Name = name;
        this.Health = 2;
    }

    public void Attack(object sender, EventArgs e)
    {
        if (this.Health > 0)
        {
            Console.WriteLine($"Footman {name} is panicking!");
        }
        if (this.health == 0)
        {
            return;
        }
        health--;
    }
}