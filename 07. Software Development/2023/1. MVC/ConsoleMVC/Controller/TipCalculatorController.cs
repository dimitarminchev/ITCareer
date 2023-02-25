using ConsoleMVC.Model;
using ConsoleMVC.Views;

namespace ConsoleMVC.Controller
{
    /// <summary>
    /// Контролер
    /// </summary>
    public class TipCalculatorController
    {
        private Tip tip = null;

        private Display display = null;

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
