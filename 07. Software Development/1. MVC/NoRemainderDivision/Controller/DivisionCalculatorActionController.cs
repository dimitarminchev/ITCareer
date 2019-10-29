using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoRemainderDivision.Model;
using NoRemainderDivision.View;

namespace NoRemainderDivision.Controller
{
    class DivisionCalculatorActionController
    {
        DivisionCalculator divisionCalculator;
        Display display;

        public DivisionCalculatorActionController()
        {
            display = new Display();
            divisionCalculator = new DivisionCalculator(display.Numbers);
            display.Percent = divisionCalculator.CalculatePercent();
            display.Print();
            
        }
    }
}
