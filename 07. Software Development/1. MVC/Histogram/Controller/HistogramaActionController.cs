using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Histogram.Model;
using Histogram.View;
namespace Histogram.Controller
{
    class HistogramaActionController
    {
        Histograma historgrama;
        Display display;

        public HistogramaActionController()
        {
            display = new Display();
            historgrama = new Histograma(display.numbers);
            display.p1 = historgrama.CalculateP1();
            display.p2 = historgrama.CalculateP2();
            display.p3 = historgrama.CalculateP3();
            display.p4 = historgrama.CalculateP4();
            display.p5 = historgrama.CalculateP5();
            display.PrintValues();
        }
    }
}
