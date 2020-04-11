using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_09.Models;
using Task_09.View;

namespace Task_09.Controllers
{
    public class Controller
    {
        public Display display;
        public Model model;

        public Controller()
        {
            display = new Display();
            model = new Model(display.magicNumber);
            display.magicNumbers = model.generateCombinations();
            display.ShowResults();
        }
    }
}
