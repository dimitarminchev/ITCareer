namespace ConsoleMVC.Views
{
    internal class Display
    {
        /// <summary>
        /// Процент за бакшиш
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// Сума за плащане
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Общо сума = Сума за сметката и сума на бакшиш
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        ///  Сума на бакшиша
        /// </summary>
        public double TipAmount { get; set; }

        /// <summary>
        /// Конструктор без параметри
        /// </summary>
        public Display()
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }

        /// <summary>
        /// Въвеждане на сума за плащане и процент за бакшиш
        /// </summary>
        public void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal: ");
            Amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percent you want to tip: ");
            Percent = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Извеждане на сума на бакшиш и обща сума за плащане
        /// </summary>
        public void ShowTipAndTotal()
        {
            Console.WriteLine("Your tip is: {0:C}", TipAmount);
            Console.WriteLine("The total will be {0:C}", Total);
        }

    }
}
