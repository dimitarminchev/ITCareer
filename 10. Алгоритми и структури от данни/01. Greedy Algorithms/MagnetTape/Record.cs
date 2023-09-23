namespace MagnetTape
{
    /// <summary>
    /// Запис на магнитната лента
    /// </summary>
    public class Record
    {
        public int Id { get; set; }

        public int Lenght { get; set; }

        public float Probability { get; set; } // 0 .. 1

        public override string ToString() => Id.ToString();
    }
}