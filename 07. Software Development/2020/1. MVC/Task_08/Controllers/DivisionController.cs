using System;

using Task_08.Models;
using Task_08.Views;

namespace Task_08.Controllers
{
    class DivisionController
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
