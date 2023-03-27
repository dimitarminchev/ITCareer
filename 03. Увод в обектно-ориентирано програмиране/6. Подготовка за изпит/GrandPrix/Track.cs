namespace GrandPrix
{
    public class Track
    {
        public Track(int lapsNumber, int trackLength)
        {
            this.Weather = "Sunny";
            this.LapsCompleted = 0;
            this.LapsNumber = lapsNumber;
            this.Length = trackLength;
        }

        public string Weather { get; set; }

        public int LapsNumber { get; }

        public int LapsCompleted { get; set; }

        public int Length { get; }

        public void CheckEnoughRemainingLaps(int lapsToGo)
        {
            if (LapsCompleted + lapsToGo > this.LapsNumber)
            {
                throw new ArgumentException(string.Format(OutputMessages.InvalidNumberOfLaps,
                    this.LapsCompleted));
            }
        }

        public bool HaveMoreLaps() => this.LapsCompleted == this.LapsNumber;
    }
}
