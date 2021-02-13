namespace ConsoleMVC.Model
{
    /// <summary>
    /// Бакшиш
    /// </summary>
    public class Tip
    {
        private double amount;
        private double percent;

        /// <summary>
        /// Сума
        /// </summary>
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Процент
        /// </summary>
        public double Percent
        {
            get { return percent; }
            set 
            {
                if (value > 1)
                {
                    percent = value / 100.0;
                }
                else
                {
                    percent = value;
                }
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="amount">Сума</param>
        /// <param name="percent">Процент</param>
        public Tip(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }

        public Tip() : this(0,0)
        {
            // nope
        }

        /// <summary>
        /// Изчисляване на сума на бакшиша
        /// </summary>
        /// <returns>Сума</returns>
        public double CalculateTip()
        {
            return Amount * Percent;
        }

        /// <summary>
        /// Изчисляване на общата сума
        /// </summary>
        /// <returns>Сума</returns>
        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
