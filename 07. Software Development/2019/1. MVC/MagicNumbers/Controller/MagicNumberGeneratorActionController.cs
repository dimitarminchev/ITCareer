using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicNumbers.Model;
using MagicNumbers.View;

namespace MagicNumbers.Controller
{
    class MagicNumberGeneratorActionController
    {
        private MagicNumberGenerator magicNumberGenerator;
        private Display display;

        public MagicNumberGeneratorActionController()
        {
            this.display = new Display();
            this.magicNumberGenerator = new MagicNumberGenerator(this.display.Product);
            this.display.AllMagicNumbers = 
                this.magicNumberGenerator.GenerateAllMagicNumbers();
            this.display.PrintAll();
        }
    }
}
