namespace Activities
{
    /// <summary>
    /// Дейност
    /// </summary>
    public class Activity
    {
        public string Name { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Start, End);
        }

        // public override string ToString() => Name;
    }
}