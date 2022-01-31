using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Controllers
{
    // Моите пространства с имена
    using ConsoleMVC.Model;
    using ConsoleMVC.Views;

    internal class TipCalculatorController
    {
        private Tip tip;
        private Display display;

        /// <summary>
        /// Конструктор на контролера
        /// </summary>
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);

            // Смята сумата на бакшиша
            display.TipAmount = tip.CalculateTip();

            // Смята общата сума за плащане
            display.Total = tip.CalculateTotal();

            // Извежда сума на бакшиш и обща сума
            display.ShowTipAndTotal();
        }
    }
}
