namespace ConsoleMVC.Model
{
    /// <summary>
    /// Бакшиш
    /// </summary>
    internal class Model
    {
        private double amount;

        /// <summary>
        /// Сума за плащане
        /// </summary>
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private double percent;

        /// <summary>
        /// Процент за бакшиш
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
        /// <param name="amount">Сума за плащане</param>
        /// <param name="percent">Процент за бакшиш</param>
        public Model(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }

        /// <summary>
        /// Конструктор по подразбиране
        /// </summary>
        public Model() : this(0, 0)
        {
            // По подразбитране
        }

        /// <summary>
        /// Калкулира сумата само на бакшиша
        /// </summary>
        /// <returns>Сума * Процент</returns>
        public double CalculateTip()
        {
            return Amount * Percent;
        }

        /// <summary>
        /// Калкулиране на общата сума за плащане
        /// </summary>
        /// <returns>Сума плюс бакшиш</returns>
        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }
    }
}
