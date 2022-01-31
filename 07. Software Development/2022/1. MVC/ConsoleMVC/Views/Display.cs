namespace ConsoleMVC.Views
{
    internal class Display
    {
        /// <summary>
        /// Процент на бакшиша
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// Сума на сметката
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Общо сума = Сума на сметката + Бакшиш
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        ///  Стойност на бакшиша
        /// </summary>
        public double TipAmount { get; set; }

        /// <summary>
        /// Конструктор
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
        /// Въвеждане на сума и процент
        /// </summary>
        public void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal: ");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want to tip: ");
            Percent = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Извежда сума на бакшиш и обща сума
        /// </summary>
        public void ShowTipAndTotal()
        {
            Console.WriteLine("Your tip is: {0:C}", TipAmount);
            Console.WriteLine("The total will be {0:C}", Total);
        }

    }
}
