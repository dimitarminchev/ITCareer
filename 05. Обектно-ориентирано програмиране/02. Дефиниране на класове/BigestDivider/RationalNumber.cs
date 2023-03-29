namespace BigestDivider
{
    public class RationalNumber
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private int denom;

        public int Denom
        {
            get { return denom; }
            set { denom = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", this.number, this.denom);
        }

        private int BigestDivider(int numerator, int denumerator)
        {
            return denumerator == 0 ? numerator : BigestDivider(denumerator, numerator % denumerator);
        }

        public RationalNumber(int numerator = 0, int denumerator = 1)
        {
            int gcd = BigestDivider(numerator, denumerator);
            this.Number = numerator / gcd;
            this.Denom = denumerator / gcd;
        }
    }
}