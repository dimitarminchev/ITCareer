namespace Jobs
{
    /// <summary>
    /// Дейност
    /// </summary>
    public class Job
    {
        public int Id { get; set; }

        public int Deadline { get; set; }

        public float Price { get; set; }

        public int Profit { get; set; }

        public override string ToString() => string.Format("j{0}", Id.ToString());
    }
}