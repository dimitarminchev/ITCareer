class Cargo
{
    public int Weight { get; set; }

    public string Type { get; set; }

    public Cargo(int weight, string type)
    {
        this.Weight = weight;
        this.Type = type;
    }
}