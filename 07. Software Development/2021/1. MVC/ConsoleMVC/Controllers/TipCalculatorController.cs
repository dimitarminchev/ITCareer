using ConsoleMVC.Model;
using ConsoleMVC.Views;

namespace ConsoleMVC.Controllers
{
    public class TipCalculatorController
    {
        /// <summary>
        /// Модел
        /// </summary>
        private Tip tip;

        /// <summary>
        /// Изглед
        /// </summary>
        private Display display;

        /// <summary>
        /// Конструктор
        /// </summary>
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }
    }
}
