using System;
using Task08.Models;
using Task08.Views;

namespace Task08.Controllers
{
    public class DivisionController
    {
        private Display display;
        private Division division;

        public DivisionController()
        {
            display = new Display();
            while (division is null)
            {
                try
                {
                    display.Input();
                    division = new Division(display.numbers);
                }
                catch (Exception e)
                {
                    display.Response = e.Message;
                    display.ShowResponse();
                }
            }
            display.Response = division.Calculate();
            display.ShowResponse();
        }
    }
}
