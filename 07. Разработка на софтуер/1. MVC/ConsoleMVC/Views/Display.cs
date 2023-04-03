namespace ConsoleMVC.Views
{
    /// <summary>
    /// Изглед
    /// </summary>
    public class Display
    {
        /// <summary>
        /// Сума на сметката
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Процент за бакшиш
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// Обща сума за плащане
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// Сума за бакшиша
        /// </summary>
        public double TipAmount { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Display()
        {
            Amount = 0;
            Percent = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }

        /// <summary>
        /// Четене на входни данни от конзолата
        /// </summary>
        public void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal: ");
            this.Amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percent you want to tip: ");
            this.Percent = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Отпечатва изходни данни на конзолата
        /// </summary>
        public void ShowTipAndTotal()
        {
            Console.WriteLine("You tip is: {0:C}", TipAmount);
            Console.WriteLine("The total will be {0:C}", Total);
        }
    }
}
