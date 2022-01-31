namespace ConsoleMVC.Controllers
{
    // Моите пространства с имена
    using ConsoleMVC.Model;
    using ConsoleMVC.Views;

    internal class Controller
    {
        private Model model;
        private Display display;

        /// <summary>
        /// Конструктор на контролера
        /// </summary>
        public Controller()
        {
            display = new Display();
            model = new Model(display.Amount, display.Percent);

            // Калкулиране на сумата на бакшиша
            display.TipAmount = model.CalculateTip();

            // Калкулиране на общата сума за плащане
            display.Total = model.CalculateTotal();

            // Извеждане на сума на бакшиш и обща сума за плащане
            display.ShowTipAndTotal();
        }
    }
}
