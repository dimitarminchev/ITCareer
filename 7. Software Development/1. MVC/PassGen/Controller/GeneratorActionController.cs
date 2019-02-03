using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassGen.Model;
using PassGen.View;

namespace PassGen.Controller
{
    class GeneratorActionController
    {
        Generator generator;
        Display display;

        public GeneratorActionController()
        {
            this.display = new Display();
            this.generator = new Generator(this.display.FirstNumber, this.display.SecondNumber);
            this.display.Passwords = this.generator.GeneratorPasswords();
            this.display.Print();
        }
    }
}
