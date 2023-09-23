namespace EgyptianFractions
{
    /// <summary>
    /// Рационално число
    /// </summary>
    public class Fraction
    {
        /// <summary>
        /// Числител
        /// </summary>
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        /// <summary>
        /// Знаменател
        /// </summary>
        private int denom;

        public int Denom
        {
            get { return denom; }
            set { denom = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="number">Числител</param>
        /// <param name="denom">Знаменател</param>
        public Fraction(int number = 0, int denom = 1)
        {
            this.number = number;
            this.denom = denom;
        }

        /// <summary>
        /// Алгоритм на Евклид за намиране на най-голям общ делител
        /// </summary>
        private int gcd(int a, int b)
        {
            if (a == 0) return b;
            return gcd(b % a, a);
        }

        /// <summary>
        /// Съкращение
        /// </summary>
        private void Simplify()
        {
            var gcd = this.gcd(this.Number, this.Denom);
            this.Number /= gcd;
            this.Denom /= gcd;
        }

        /// <summary>
        /// Предефиниране на оператор +
        /// </summary>
        public static Fraction operator +(Fraction left, Fraction right)
        {
            var temp = new Fraction(left.number * right.denom + left.denom * right.number, left.denom * right.denom);
            temp.Simplify();
            return temp;
        }

        /// <summary>
        /// Предефиниране на оператор <
        /// </summary>
        public static bool operator <(Fraction left, Fraction right)
        {
            var leftExp = new Fraction(left.number * right.denom, left.denom * right.denom);
            var rigthExp = new Fraction(right.number * left.denom, right.denom * left.denom);
            if (leftExp.Number <= rigthExp.Number) return true;
            return false;
        }

        /// <summary>
        /// Предефиниране на оператор >
        /// </summary>
        public static bool operator >(Fraction left, Fraction right)
        {
            var leftExp = new Fraction(left.number * right.denom, left.denom * right.denom);
            var rigthExp = new Fraction(right.number * left.denom, right.denom * left.denom);
            if (leftExp.Number >= rigthExp.Number) return true;
            return false;
        }

        /// <summary>
        /// Предефиниране на оператор ==
        /// </summary>
        public static bool operator ==(Fraction left, Fraction right)
        {
            if (left.Number == right.Number && left.Denom == right.Denom) return true;
            return false;
        }

        /// <summary>
        /// Предефиниране на оператор !=
        /// </summary>
        public static bool operator !=(Fraction left, Fraction right)
        {
            return left == right;
        }

        /// <summary>
        /// Печатащ метод
        /// </summary>
        public override string ToString()
        {
            return string.Format("[{0}/{1}]", this.number, this.denom);
        }
    }
}
