namespace ConsoleMVC.Model
{
    /// <summary>
    /// Бакшиш
    /// </summary>
    internal class Tip
    {
        private double amount;

        /// <summary>
        /// Стойност
        /// </summary>
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private double percent;

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
                    this.percent = value / 100.0;
                }
                else 
                {
                    this.percent = value;
                }
            }
        }

        /// <summary>
        /// Конструктор с параметри
        /// </summary>
        /// <param name="amount">Сума</param>
        /// <param name="percent">Процент бакшиш</param>
        public Tip(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }

        /// <summary>
        /// Конструктор по подразбиране
        /// </summary>
        public Tip() : this(0, 0)
        {
            // По подразбитране
        }

        /// <summary>
        /// Смята сумата на бакшиша
        /// </summary>
        /// <returns>Сума * Процент</returns>
        public double CalculateTip()
        {
            return Amount * Percent;
        }

        /// <summary>
        /// Смята общата сума за плащане
        /// </summary>
        /// <returns>Сума плюс бакшиша</returns>
        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
