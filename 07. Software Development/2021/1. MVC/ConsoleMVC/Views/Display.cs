using System;

namespace ConsoleMVC.Views
{
    public class Display
    {
        /// <summary>
        /// Процент
        /// </summary>
        public double Percent { get; set; }

        /// <summary>
        /// Сума
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Всичко
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// Сума за бакшиш
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
        /// Задаване на данни
        /// </summary>
        private void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal:");
            Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percent you want to tip:");
            Percent = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Извежда Башкиш и Обща сума
        /// </summary>
        public void ShowTipAndTotal()
        {
            Console.WriteLine("Your tip is: {0:C}", TipAmount);
            Console.WriteLine("The total will be {0:C}", Total);
        }
    }
}
